using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace xphu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string connString = "SERVER = localhost;"
                                   + "DATABASE = nhom;"
                                   + "USERNAME = root;"
                                   + "PASSWORD = 860232;";

        public bool Account(Account userinfo)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select Role from Account where IdAcc = @IdAcc and Pass = @Pass", conn);
            cmd.Parameters.AddWithValue("@IdAcc", userinfo.idacc);
            cmd.Parameters.AddWithValue("@Pass", userinfo.pass);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["Role"].ToString())
                {
                    case "1":
                        {
                            return true;
                        }
                    case "0":
                        {
                            return false;
                        }
                }
            }
            return true;
        }

        public bool DangNhap(Account userinfo)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Account where IdAcc = @IdAcc and Pass = @Pass", conn);
            cmd.Parameters.AddWithValue("@IdAcc", userinfo.idacc);
            cmd.Parameters.AddWithValue("@Pass", userinfo.pass);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet DsAcount()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from Account", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        public bool ThemAc(Account them)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Insert Into Account(IdAcc,Name,Role,Pass) Values (@IdAcc,@Name,@Role,@Pass)", conn);
                cmd.Parameters.AddWithValue("@idacc", them.idacc);
                cmd.Parameters.AddWithValue("@pass", them.pass);
                cmd.Parameters.AddWithValue("@role", them.role);
                cmd.Parameters.AddWithValue("@name", them.name);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            conn.Close();
            return true;
        }
        public bool SuaAc(Account sua)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update Account set Name=@Name, Pass=@Pass, Role=@Role where IdAcc=@IdAcc;", conn);
            cmd.Parameters.AddWithValue("@Name", sua.name);
            cmd.Parameters.AddWithValue("@Pass", sua.pass);
            cmd.Parameters.AddWithValue("@Role", sua.role);
            cmd.Parameters.AddWithValue("@IdAcc", sua.idacc);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            conn.Close();
            return true;
        }
        public bool XoaAc(Account xoa)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete  From Account Where IdAcc=@IdAcc", conn);
            cmd.Parameters.AddWithValue("@IdAcc", xoa.idacc);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public DataSet DsContents()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select Contents from nhom.option where Code like'1'", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        public DataSet DsAns()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select Contents,Code,IdOpt from nhom.option where Code not like'1'", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;

        }
        public bool ThemOption(Option them )
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                DateTime n = DateTime.Now;
                string d = n.ToString("yyyy-MM-dd HH:mm:ss");
                MySqlCommand cmd = new MySqlCommand("Insert Into nhom.option(IdOpt,Contents,Code,DeadlineTime) Values (@IdOpt,@Contents,@Code,@DeadlineTime)", conn);
                cmd.Parameters.AddWithValue("@idopt", them.idopt);
                cmd.Parameters.AddWithValue("@contents", them.contents);
                cmd.Parameters.AddWithValue("@code", them.code);
                cmd.Parameters.AddWithValue("@deadlinetime", d);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            conn.Close();
            return true;
        }
        public bool XoaOption(Option xoa)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete  From nhom.option Where Code=@Code", conn);
            cmd.Parameters.AddWithValue("@Code", xoa.code);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        public bool LoadContent(Vote vote)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Contents from nhom.vote inner join nhom.option on vote.IdOpt = nhom.option.IdOpt where nhom.vote.IdVote = @IdVote;", conn);
            cmd.Parameters.AddWithValue("@IdAcc", vote.idacc);
            cmd.Parameters.AddWithValue("@IdOpt", vote.idopt);
            cmd.Parameters.AddWithValue("@IdVote", vote.idvote);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SuaOption(Option sua)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update nhom.option set option.Contents=@Contents where option.Code=@Code;", conn);
            cmd.Parameters.AddWithValue("@Code", sua.code);
            cmd.Parameters.AddWithValue("Contents", sua.contents);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            conn.Close();
            return true;
        }
        public DataSet DsOption()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT  Contents from nhom.option;", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }

        public DataSet DsCode()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT  account.Name, option.Contents, option.IdOpt, vote.Time FROM ((nhom.vote INNER JOIN nhom.account ON vote.IdAcc = account.IdAcc)INNER JOIN nhom.option ON  vote.Code = option.Code);", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }

        public bool SuaVote(Vote sua)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update nhom.vote set vote.Code=@Code,vote.Flag=1 where IdAcc=@IdAcc;", conn);
            cmd.Parameters.AddWithValue("@Code", sua.code);
            cmd.Parameters.AddWithValue("@IdAcc", sua.idacc);
            cmd.Parameters.AddWithValue("@Flag", sua.flag);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return true;
                }
            }
            else
            {
                return false;   
            }
            conn.Close();
            return true;
        }

        public bool ThemVote(Vote them)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                DateTime n = DateTime.Now;
                string d = n.ToString("yyyy-MM-dd HH:mm:ss");
                MySqlCommand cmd = new MySqlCommand("Insert Into nhom.vote(IdAcc,Code,IdOpt,Time,Flag) Values (@IdAcc,@Code,@IdOpt,@Time,@Flag)", conn);
                cmd.Parameters.AddWithValue("@IdAcc", them.idacc);
                cmd.Parameters.AddWithValue("@code", them.code);
                cmd.Parameters.AddWithValue("@IdOpt", them.idopt);
                cmd.Parameters.AddWithValue("@Time", d);
                cmd.Parameters.AddWithValue("@Flag", them.flag);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            conn.Close();
            return true;
        }
        public bool Idacc(Vote timid)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select IdAcc from nhom.vote where IdAcc = @IdAcc", conn);
            cmd.Parameters.AddWithValue("@IdAcc", timid.idacc);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataSet Dsopt()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT distinct option.IdOpt FROM nhom.option;", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        public DataSet Luotvote()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Code,count(Code) as Code1 FROM nhom.vote GROUP BY Code;", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        public bool CapnhatFlag(Vote flag)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select Flag from nhom.vote where IdAcc = @IdAcc ", conn);
            cmd.Parameters.AddWithValue("@IdAcc", flag.idacc);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["Flag"].ToString())
                {
                    case "1":
                        {
                            return true;
                        }
                    case "0":
                        {
                            return false;
                        }
                }
            }
            return true;
        }
    }
}
