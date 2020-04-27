using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace xphu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataSet DsAcount();
        [OperationContract]
        bool DangNhap(Account userinfo);
        [OperationContract]
        bool Account(Account userinfo);
        [OperationContract]
        bool ThemAc(Account them);
        [OperationContract]
        bool SuaAc(Account sua);
        [OperationContract]
        bool XoaAc(Account xoa);
        [OperationContract]
        bool ThemOption(Option them );
        [OperationContract]
        bool XoaOption(Option xoa);
        [OperationContract]
        DataSet DsContents();
        [OperationContract]
        DataSet DsAns();
        [OperationContract]
        bool LoadContent(Vote vote);
        [OperationContract]
        DataSet DsOption();
        [OperationContract]
        DataSet DsCode();
        [OperationContract]
        bool SuaVote(Vote sua);
        [OperationContract]
        bool ThemVote(Vote them);
        [OperationContract]
        bool SuaOption(Option sua);
        [OperationContract]
        bool Idacc(Vote timid);
        [OperationContract]
        DataSet Dsopt( );
        [OperationContract]
        DataSet Luotvote();
        [OperationContract]
        bool CapnhatFlag(Vote flag);
    }
    public class Option
    {
        string Contents;
        string IdOpt;
        string Code;
        DateTime DeadlineTime;
        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        public DateTime deadlinetime
        {
            get { return DeadlineTime; }
            set { DeadlineTime = value; }
        }
        public string idopt
        {
            get { return IdOpt; }
            set { IdOpt = value; }
        }

        public string contents
        {
            get { return Contents; }
            set { Contents = value; }
        }
    }
    public class Account
    {
        string IdAcc;
        string Name;
        bool Role;
        string Pass;
       
        public string idacc
        {
            get { return IdAcc; }
            set { IdAcc = value; }
        }
        [DataMember]
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        [DataMember]
        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }
        [DataMember]
        public bool role
        {
            get { return Role; }
            set { Role = value; }
        }
    }
    public class Vote
    {
        string IdVote;
        string IdAcc;
        string IdOpt;
        string Code;
        DateTime Time;
        bool Flag;
        [DataMember]
        public bool flag
        {
            get { return Flag; }
            set { Flag = value; }
        }
        [DataMember]
        public string idvote
        {
            get { return IdVote; }
            set { IdVote = value; }
        }
        [DataMember]
        public string idacc
        {
            get { return IdAcc; }
            set { IdAcc = value; }
        }
        [DataMember]
        public string idopt
        {
            get { return IdOpt; }
            set { IdOpt = value; }
        }
        [DataMember]
        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        [DataMember]
        public DateTime time
        {
            get { return Time; }
            set { Time = value; }
        }
    }
}
