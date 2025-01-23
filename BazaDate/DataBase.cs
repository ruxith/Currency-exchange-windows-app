using _2_1061_PICHERMAYER_RUXANDRA.Entities;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace _2_1061_PICHERMAYER_RUXANDRA.BazaDate
{
    public class DataBase
    {
        //ADAUGARE
        public void AddTranzactie(Tranzactii transaction)
        {
            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "INSERT INTO Tranzactii (ID, IDValuta, Suma, Data, Tip)" +
                    "VALUES (:transactionID, :valutaID, :suma, :data, :tip)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("transactionID", OracleDbType.Varchar2).Value = transaction.ID;
                    cmd.Parameters.Add("valutaID", OracleDbType.Varchar2).Value = transaction.IDValuta;
                    cmd.Parameters.Add("suma", OracleDbType.Decimal).Value = transaction.Suma;
                    cmd.Parameters.Add("data", OracleDbType.Date).Value = transaction.Data;
                    cmd.Parameters.Add("tip", OracleDbType.Varchar2).Value = transaction.Tip;

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void AddCursValutar(CursuriValutare curs)
        {
            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "INSERT INTO CursuriValutare (ID, IDValuta, Data, CursCumparare, CursVanzare) " +
                             "VALUES (:id, :idValuta, :data, :cursCumparare, :cursVanzare)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = curs.ID.ToString();
                    cmd.Parameters.Add("idValuta", OracleDbType.Varchar2).Value = curs.IDValuta.ToString();
                    cmd.Parameters.Add("data", OracleDbType.Date).Value = curs.DataCursului;
                    cmd.Parameters.Add("cursCumparare", OracleDbType.Decimal).Value = curs.CursCumparare;
                    cmd.Parameters.Add("cursVanzare", OracleDbType.Decimal).Value = curs.CursVanzare;

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

        }

        public void AddValuta(Valuta valuta)
        {
            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "INSERT INTO Valuta (ID, Nume, Cod, Minim, Maxim) " +
                             "VALUES (:id, :nume, :cod, :minim, :maxim)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = valuta.ID.ToString();
                    cmd.Parameters.Add("nume", OracleDbType.Varchar2).Value = valuta.Nume;
                    cmd.Parameters.Add("cod", OracleDbType.Varchar2).Value = valuta.Cod;
                    cmd.Parameters.Add("minim", OracleDbType.Decimal).Value = valuta.Minim;
                    cmd.Parameters.Add("maxim", OracleDbType.Decimal).Value = valuta.Maxim;

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        //EDITURI
        public void EditTranzactie(Tranzactii transaction)
        {
            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                //fa un slelect care sa ti ia id ul de valuta dandu-i numele

                string sql = "UPDATE TRANZACTII " +
                    "SET IDValuta = :idValuta, Suma = :suma " +
                    "WHERE ID = :transactionID";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("idValuta", OracleDbType.Varchar2).Value = transaction.IDValuta.ToString();
                    cmd.Parameters.Add("suma", OracleDbType.Decimal).Value = transaction.Suma;
                    cmd.Parameters.Add("transactionID", OracleDbType.Varchar2).Value = transaction.ID;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void EditCursValutar(CursuriValutare curs)
        {
            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "UPDATE CursuriValutare " +
                    "SET CURSCUMPARARE = :CURSC, CURSVANZARE = :CURSV " +
                    "WHERE ID = :CURSID";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("CURSC", OracleDbType.Decimal).Value = curs.CursCumparare;
                    cmd.Parameters.Add("CURSV", OracleDbType.Decimal).Value = curs.CursVanzare;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }

        //GETTERI
        public List<Tranzactii> GetTranzactii()
        {
            List<Tranzactii> tranzactiiList = new List<Tranzactii>();

            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT T.ID, T.IDValuta, V.COD AS NumeValuta, T.SUMA, T.DATA, T.TIP " +
                     "FROM TRANZACTII T " +
                     "JOIN Valuta V ON T.IDVALUTA = V.ID ";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tranzactii tranzactie = new Tranzactii();
                            tranzactie.ID = reader["ID"].ToString();
                            tranzactie.IDValuta = reader["IDValuta"].ToString();
                            tranzactie.NumeValuta = reader["NumeValuta"].ToString();
                            tranzactie.Suma = reader.GetDecimal(reader.GetOrdinal("Suma"));
                            tranzactie.Data = reader.GetDateTime(reader.GetOrdinal("Data"));
                            tranzactie.Tip = reader["Tip"].ToString();

                            tranzactiiList.Add(tranzactie);
                        }
                    }
                }
                conn.Close();
            }

            return tranzactiiList;
        }

        public BindingList<Tranzactii> GetTranzactii(DateTime data)
        {
            BindingList<Tranzactii> tranzactiiList = new BindingList<Tranzactii>();

            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT T.ID, t.IDValuta, V.COD AS NumeValuta, T.SUMA, T.DATA, T.TIP " +
                     "FROM TRANZACTII T " +
                     "JOIN Valuta V ON T.IDVALUTA = V.ID " +
                     "WHERE TRUNC(T.DATA) = :data";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("data", OracleDbType.Date).Value = data.Date;
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tranzactii tranzactie = new Tranzactii();
                            tranzactie.ID = reader["ID"].ToString();
                            tranzactie.IDValuta = reader["IDValuta"].ToString();
                            tranzactie.NumeValuta = reader["NumeValuta"].ToString();
                            tranzactie.Suma = reader.GetDecimal(reader.GetOrdinal("SUMA"));
                            tranzactie.Data = reader.GetDateTime(reader.GetOrdinal("DATA"));
                            tranzactie.Tip = reader["TIP"].ToString();

                            tranzactiiList.Add(tranzactie);
                        }
                    }
                }
                conn.Close();
            }

            return tranzactiiList;
        }

        public BindingList<CursuriValutare> GetCursValutar(DateTime data)
        {
            BindingList<CursuriValutare> cursuri = new BindingList<CursuriValutare>();

            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT CV.ID, CV.Data, CV.CursCumparare, CV.CursVanzare, CV.IDValuta as IDValuta,  V.Nume AS NumeValuta " +
                    "FROM CursuriValutare CV " +
                    "JOIN Valuta V ON CV.IDValuta = V.ID " +
                    "WHERE TRUNC(CV.Data) = :data";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {

                    cmd.Parameters.Add("data", OracleDbType.Date).Value = data.Date;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            CursuriValutare curs = new CursuriValutare();
                            curs.ID = reader["ID"].ToString();
                            curs.IDValuta = reader["IDValuta"].ToString();
                            curs.NumeValuta = reader["NumeValuta"].ToString();
                            curs.DataCursului = reader.GetDateTime(reader.GetOrdinal("Data"));
                            curs.CursCumparare = reader.GetDecimal(reader.GetOrdinal("CursCumparare"));
                            curs.CursVanzare = reader.GetDecimal(reader.GetOrdinal("CursVanzare"));

                            cursuri.Add(curs);
                        }
                    }
                }
                conn.Close();
            }

            return cursuri;
        }
        public List<CursuriValutare> GetCursValutarList(DateTime data)
        {
            List<CursuriValutare> cursuri = new List<CursuriValutare>();

            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT CV.ID, CV.Data, CV.CursCumparare, CV.CursVanzare, CV.IDValuta as IDValuta,  V.Nume AS NumeValuta " +
                    "FROM CursuriValutare CV " +
                    "JOIN Valuta V ON CV.IDValuta = V.ID " +
                    "WHERE TRUNC(CV.Data) = :data";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {

                    cmd.Parameters.Add("data", OracleDbType.Date).Value = data.Date;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            CursuriValutare curs = new CursuriValutare();
                            curs.ID = reader["ID"].ToString();
                            curs.IDValuta = reader["IDValuta"].ToString();
                            curs.NumeValuta = reader["NumeValuta"].ToString();
                            curs.DataCursului = reader.GetDateTime(reader.GetOrdinal("Data"));
                            curs.CursCumparare = reader.GetDecimal(reader.GetOrdinal("CursCumparare"));
                            curs.CursVanzare = reader.GetDecimal(reader.GetOrdinal("CursVanzare"));

                            cursuri.Add(curs);
                        }
                    }
                }
                conn.Close();
            }

            return cursuri;
        }
        public List<CursuriValutare> GetAllCursValutar()
        {
            List<CursuriValutare> cursuri = new List<CursuriValutare>();

            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT CV.ID, CV.Data, CV.CursCumparare, CV.CursVanzare, CV.IDValuta as IDValuta,  V.Nume AS NumeValuta " +
                    "FROM CursuriValutare CV " +
                    "JOIN Valuta V ON CV.IDValuta = V.ID ";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            CursuriValutare curs = new CursuriValutare();
                            curs.ID = reader["ID"].ToString();
                            curs.IDValuta = reader["IDValuta"].ToString();
                            curs.NumeValuta = reader["NumeValuta"].ToString();
                            curs.DataCursului = reader.GetDateTime(reader.GetOrdinal("Data"));
                            curs.CursCumparare = reader.GetDecimal(reader.GetOrdinal("CursCumparare"));
                            curs.CursVanzare = reader.GetDecimal(reader.GetOrdinal("CursVanzare"));

                            cursuri.Add(curs);
                        }
                    }
                }
                conn.Close();
            }

            return cursuri;
        }
        public List<Valuta> GetAllValute()
        {
            List<Valuta> valuteList = new List<Valuta>();

            using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Valuta";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Valuta valuta = new Valuta();
                            valuta.ID = reader["ID"].ToString();
                            valuta.Nume = reader["Nume"].ToString();
                            valuta.Cod = reader["Cod"].ToString();
                            valuta.Minim = reader.GetDecimal(reader.GetOrdinal("Minim"));
                            valuta.Maxim = reader.GetDecimal(reader.GetOrdinal("Maxim"));
                            valuteList.Add(valuta);
                        }
                    }
                }
                conn.Close();
            }

            return valuteList;
        }

        //STERGERI
        public void DeleteCursValutar(string cursID)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM CURSURIVALUTARE WHERE ID = :CURSID";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {

                        cmd.Parameters.Add("CURSID", OracleDbType.Varchar2).Value = cursID.ToString();

                        cmd.ExecuteNonQuery();
                     
                    }

                    conn.Close();
                }
            }catch (OracleException)
            {
                MessageBox.Show("Unable to delete Curs Valutar record. There are dependent records in other tables.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void DeleteValuta(string valutaId)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM VALUTA WHERE ID = :valutaID";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {

                        cmd.Parameters.Add("valutaID", OracleDbType.Varchar2).Value = valutaId.ToString();

                        cmd.ExecuteNonQuery();

                    }

                    conn.Close();
                }
            }
            catch (OracleException)
            {
                MessageBox.Show("Unable to delete Valuta record. There are dependent records in other tables.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteTranzactie(string tranzactieId)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DataBaseInfo.ConnectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM TRANZACTII WHERE ID = :valutaID";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {

                        cmd.Parameters.Add("valutaID", OracleDbType.Varchar2).Value = tranzactieId.ToString();

                        cmd.ExecuteNonQuery();

                    }

                    conn.Close();
                }
            }
            catch (OracleException)
            {
                MessageBox.Show("Unable to delete tranzactie record. There are dependent records in other tables.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
