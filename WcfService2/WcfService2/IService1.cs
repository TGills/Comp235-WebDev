using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here 
        [OperationContract]
        string Welcome(string userName);

        [OperationContract]
        Equation GenerateEquation();

        [OperationContract]
        List<Movie> GetAllMovies();

        [OperationContract]
        List<MovieCategory> getAllMovieCategories();

        [OperationContract]
        List<Movie> getAllMoviesByCategory(int catId);


        [OperationContract]
        List<STOCK> getAllStocks();
        [OperationContract]
        List<STOCK> getStockByCode(string code);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    [DataContract]
    public class Movie
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Director { get; set; }
        [DataMember]
        public string Description { get; set; }
        public Movie() { }
        public Movie(string title, string director, string description)
        {
            Title = title;
            Director = director;
            Description = description;
        }
    }
    [DataContract]
    public class Equation
    {
        [DataMember]
        public int Left { get; set; }

        [DataMember]
        public int Right { get; set; }

        [DataMember]
        public int Result { get; set; }

        [DataMember]
        public string Operation { get; set; }

        public Equation() { }

        public Equation(int lValue, int rValue, string type)
        {
            Left = lValue;
            Right = rValue;
            switch (type)
            {
                case "add":
                    Result = Left + Right;
                    Operation = "+";
                    break;
                case "subtract":
                    Result = Left - Right;
                    Operation = "-";
                    break;
                case "multiply":
                    Result = Left * Right;
                    Operation = "*";
                    break;
            }
        }

        [DataMember]
        public string LeftSide
        {
            get
            {
                return String.Format("{0} {1} {2}",
                    Left.ToString(),
                    Operation,
                    Right.ToString());
            }
            set { }
        }

        [DataMember]
        public string RightSide
        {
            get
            {
                return String.Format("{0}", Result.ToString());
            }
            set { }
        }
    }
    [DataContract]
    public class MovieCategory
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Position { get; set; }
        public MovieCategory() { }
        public MovieCategory(int id, string name)
        {
            Id = id;
            Name = name;

        }
    }



    //Test
    [DataContract]
    public class STOCK{
        [DataMember]
        private String stockName { get; set; }
        [DataMember]
        private String stockCode { get; set; }
        [DataMember]
        private int quantity { get; set; }
        [DataMember]
        private double price { get; set; }

        public STOCK() { }
        public STOCK(string code, string name, int shares, double priceprice)
        {
            stockName = name;
            stockCode = code;
            quantity = shares;
            price = priceprice;
        }


    }
}

