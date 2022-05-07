using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySqlConnector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterinoApp
{
    internal class ConexiuneBD {

         private static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = "<adresa/ip-ul bazei de date>",
            UserID = "<username>",
            Password = "<parola>",
            Database = "<numele bazei de date>",
        };

        private static MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

        private static string parola_decriptata;
        
        public static Boolean logare(String username, String parola, ErrorProvider errors, TextBox user, TextBox pass) {
            try {
                connection.Open();
                String search = "SELECT * from <nume_tabela> WHERE username='" + username + "'";

                MySqlCommand sqlcommand = new MySqlCommand(search, connection);
                MySqlDataReader dr = sqlcommand.ExecuteReader();

                /* Verificam daca userul exista in baza de date, iar daca exista, daca parola setata este corecta. */
                if (dr.Read()) /* Userul exista. */
                {
                    /* User corect si parola corecta. */
                    if (dr.GetString(1).Equals(parola)) { /* Al doilea camp (a doua coloana) este parola. */
                        errors.SetError(user, "");
                        errors.SetError(pass, "");
                        return true;
                    }
                    errors.SetError(user, "");
                    errors.SetError(pass, "Parola incorecta!");
                    return false;
                }
                else {
                        MessageBox.Show("Date incorecte." + Environment.NewLine + "Contul " + username + " nu exista.", "Chatterino! - Cont inexistent", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                }
            }
            catch (SqlException e) {
                MessageBox.Show("Eroare la conectarea la baza de date: " + e.Message, "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                connection.Close();
            }
            return false;
        }
        public static Boolean adaugare(String username, String parola, String email)
        {
            try
            {
                connection.Open();

                /* Introducem un nou utilizator in baza de date. */
                String search = "SELECT username, email from <nume_tabela>";
                String insert = "INSERT into <nume_tabela> (username, password, email) values (@user, @pass, @email)";

                MySqlCommand inserare = new MySqlCommand(insert, connection);  

                using (MySqlCommand sqlcommand = new MySqlCommand(search, connection)) {
                    using (MySqlDataReader reader = sqlcommand.ExecuteReader()) {
                        while (reader.Read()) {
                            /* Verificam daca nu deja exista un user cu username-ul specificat
                             * sau cu email-ul specificat. */
                            if (reader.GetString(0).Equals(username)) {
                                MessageBox.Show("Username-ul " + username + " este folosit." + Environment.NewLine + "Alegeti un alt username.", "Chatterino! - Nu se poate crea contul", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            if (reader.GetString(1).Equals(email))
                            {
                                MessageBox.Show("Exista deja un cont inregistrat cu email-ul " + email + "." + Environment.NewLine + "Alegeti un alt email.", "Chatterino! - Nu se poate crea contul", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }

                /* Daca nu exista, il adaugam. */
                inserare.Parameters.AddWithValue("@user", username);
                inserare.Parameters.AddWithValue("@pass", parola);
                inserare.Parameters.AddWithValue("@email", email);
                inserare.ExecuteNonQuery();

                return true;

            }
            catch (SqlException e) {
                MessageBox.Show("Eroare la conectarea la baza de date: " + e.Message, "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                connection.Close();
            }
            return false;
        }  
        
        public static Boolean cautare(String username, String email) {
            try
            {
                connection.Open();
                String search = "SELECT * from <nume_tabela> WHERE username='" + username + "' AND email='" + email + "'";

                MySqlCommand sqlcommand = new MySqlCommand(search, connection);
                MySqlDataReader dr = sqlcommand.ExecuteReader();

                /* Verificam daca userul exista in baza de date, iar daca exista, verificam daca email-ul corespunde. */
                if (dr.Read()) /* Userul exista. */
                {
                    /* User si email corect. */
                    /* Al treilea camp (a treia coloana) este email-ul. */
                    if (dr.GetString(2).Equals(email))
                    {
                        var bytes = Convert.FromBase64String(dr.GetString(1));
                        parola_decriptata = CriptareParola.decryptParola(bytes);
                        returneazaParola();
                        return true;
                    }
                    return false;
                }
                else
                    return false;
            }
            catch(SqlException e) {
                MessageBox.Show("Eroare la conectarea la baza de date: " + e.Message, "Chatterino! - Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                connection.Close();
            }
            return false;
        }
        public static String returneazaParola() {
            return parola_decriptata;
        }
    }
}
