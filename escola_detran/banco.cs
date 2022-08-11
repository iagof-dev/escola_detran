using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace escola_detran
{
    internal class banco
    {
        //Banco de dados
        public static string db_ip = "db.n3rdydzn.software";
        public static string db_user = "*******";
        public static string db_pass = "*********";
        public static string db_database = "nrdydesi_detran";

        public static string db_dados = "server=" + db_ip + ";user=" + db_user + ";database=" + db_database + ";port=3306;password=" + db_pass + "";
        public static MySqlConnection db_conn = new MySqlConnection(db_dados);

        //Tabelas
        public static string tb_prop = "proprietario";
        public static string tb_cnh = "cnh";
        public static string tb_agentes = "agente";
        public static string tb_cor = "cor";
        public static string tb_estado = "estado";
        public static string tb_infracao = "infracao";
        public static string tb_marca = "marca";
        public static string tb_modelo = "modelo";
        public static string tb_multas = "multas";
        public static string tb_sexo = "sexo";
        public static string tb_veiculo = "veiculo";
        public static string tb_cidade = "cidade";


        //Proprietário Info
        public static string[] proprietario = new string[16];
        public static bool propri_ownveh = false;
        //0 = ID
        //1 = Nome
        //2 = cpf
        //3 = cnh
        //4 = enderco
        //5 = numero
        //6 = complemento
        //7 = bairro
        //8 = CEP
        //9 = cadastro
        //10 = veiculo
        //11 = genero
        //12 = cidade
        //13 = estado
        //14 = possui veiculo?
        //15 = validade cnh


        ///Detalhes do Veiculo
        public static string[] vehicle = new string[9];
        //0 = id
        //1 = placa
        //3 = cadastro
        //4 = multas
        //5 = modelo
        //6 = cor
        //7 = marca

        public static bool funcionario = false;
        public static bool verified = false;

        public static void setform(Form pagina, Panel painel)
        {
            if (painel.Controls.Count > 0)
                painel.Controls.RemoveAt(0);
            Form mostrar = pagina as Form;
            mostrar.TopLevel = false;
            mostrar.Dock = DockStyle.Fill;
            painel.Controls.Add(mostrar);
            painel.Tag = mostrar;
            mostrar.Show();
        }


        public static void loader_verify()
        {
            System.Diagnostics.Debug.WriteLine("Banco de Dados | Conectando...");
            try
            {
                db_conn.Open();
                System.Diagnostics.Debug.WriteLine("Banco de Dados | Conectado!");
                verified = true;
            }
            catch (Exception e)
            {
                verified = false;
                System.Diagnostics.Debug.WriteLine("Banco de Dados | Erro! " + e);
                Environment.Exit(0);
            }
            db_conn.Close();
            System.Diagnostics.Debug.WriteLine("Banco de Dados | Conexão Fechada!");
        }


        public static void get_veh(string busca, object tipo)
        {
            int marcaid = 0;
            db_conn.Open();
            string search = "select * from " + tb_veiculo + " where " + tipo + "='" + busca + "';";
            MySqlCommand comm = new MySqlCommand();
            var com = db_conn.CreateCommand();
            com.CommandText = search;
            var reader = com.ExecuteReader();
            while (reader.Read())
            {
                vehicle[0] = reader.GetString("id");
                vehicle[1] = reader.GetString("placa");
                //vehicle[2] = reader.GetString("cadastro");
                vehicle[3] = reader.GetString("multas");
                vehicle[4] = reader.GetString("modelo");
                vehicle[5] = reader.GetString("cor");

            }
            reader.Close();

            string sea_modelo = "select * from " + tb_modelo + " where id='" + vehicle[0] + "';";
            MySqlCommand coma = new MySqlCommand();
            var comai = db_conn.CreateCommand();
            comai.CommandText = sea_modelo;
            var reader1 = comai.ExecuteReader();
            while (reader1.Read())
            {
                marcaid = reader1.GetInt32("marca") ;
                vehicle[4] = reader1.GetString("nome");

            }
            reader1.Close();

            string sea_cor = "select * from " + tb_cor + " where id='" + vehicle[5] + "';";
            MySqlCommand come = new MySqlCommand();
            var damn = db_conn.CreateCommand();
            damn.CommandText = sea_cor;
            var reader2 = damn.ExecuteReader();
            while (reader2.Read())
            {
                vehicle[5] = reader2.GetString("nome");

            }
            reader2.Close();

            string sea_marca = "select * from " + tb_marca + " where id='" + marcaid + "';";
            MySqlCommand como = new MySqlCommand();
            var damn2 = db_conn.CreateCommand();
            damn2.CommandText = sea_marca;
            var reader3 = damn2.ExecuteReader();
            while (reader3.Read())
            {
                vehicle[6] = reader3.GetString("nome") ;

            }
            reader3.Close();


            db_conn.Close();
        }





            public static void get_prop(string busca, object tipo)
        {
            db_conn.Open();
            string search = "select * from " + tb_prop + " where " + tipo + "='" + busca + "';";
            MySqlCommand comm = new MySqlCommand();
            var com = db_conn.CreateCommand();
            com.CommandText = search;
            var reader = com.ExecuteReader();
            while (reader.Read())
            {
                proprietario[0] = reader.GetString("id");
                proprietario[1] = reader.GetString("nome");
                proprietario[2] = reader.GetString("cpf");
                proprietario[3] = reader.GetString("cnh");
                proprietario[4] = reader.GetString("endereco");
                proprietario[5] = reader.GetString("numero");
                proprietario[6] = reader.GetString("complemento");
                proprietario[7] = reader.GetString("bairro");
                proprietario[8] = reader.GetString("cep");
                proprietario[9] = reader.GetString("cadastro");
                propri_ownveh = reader.GetBoolean("own_veh");

                if (propri_ownveh == true)
                {
                    proprietario[10] = reader.GetString("veiculo");
                }
                else
                {
                    proprietario[10] = "Não Possui";
                }

                proprietario[11] = reader.GetString("sexo");
                proprietario[13] = reader.GetString("estado");
                proprietario[12] = reader.GetString("cidade");
            }
            reader.Close();

            MySqlCommand cnh = new MySqlCommand();
            var cnhh = db_conn.CreateCommand();
            string cnhcom = "select * from " + tb_cnh + " where pessoa='" + proprietario[3] + "';";
            cnhh.CommandText = cnhcom;
            var reader2 = cnhh.ExecuteReader();

            while (reader2.Read())
            {
                proprietario[15] = reader2.GetString("validade");
            }

            reader2.Close();

            MySqlCommand gen = new MySqlCommand();
            var generocom = db_conn.CreateCommand();
            string gencom = "select * from " + tb_sexo + " where id='" + proprietario[11] + "';";
            generocom.CommandText = gencom;
            var reader3 = generocom.ExecuteReader();

            while (reader3.Read())
            {
                proprietario[11] = reader3.GetString("Nome");
            }
            reader3.Close();

            MySqlCommand cid = new MySqlCommand();
            var cidade = db_conn.CreateCommand();
            string com_cidade = "select * from " + tb_cidade + " where id='" + proprietario[12] + "';";
            cidade.CommandText = com_cidade;
            var reader4 = cidade.ExecuteReader();
            while (reader4.Read())
            {
                proprietario[12] = reader4.GetString("nome");
            }
            reader4.Close();

            MySqlCommand estado = new MySqlCommand();
            var estd = db_conn.CreateCommand();
            string com_estd = "select * from " + tb_estado + " where id='" + proprietario[13] + "';";
            estd.CommandText = com_estd;
            var reader5 = estd.ExecuteReader();
            while (reader5.Read())
            {
                proprietario[13] = reader5.GetString("nome");
            }
            reader5.Close();


            MySqlCommand cnhvalid = new MySqlCommand();
            var cnvalid = db_conn.CreateCommand();
            string com_cnhvalid = "select * from " + tb_cnh + " where id='" + proprietario[3] + "';";
            cnvalid.CommandText = com_cnhvalid;
            var reader6 = cnvalid.ExecuteReader();
            while (reader6.Read())
            {
                proprietario[15] = reader6.GetString("validade");
            }
            reader6.Close();

            db_conn.Close();


        }





    }
}
