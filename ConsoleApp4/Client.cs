using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Client
    {
        public int id;
        public string name;
        public string adress;
        public int phone;
        public int countOfRequests;
        public double sum;
        public ClientType type;
        
        public Client() {}
        public Client(int id, string name, string adress, int phone, int countOfRequests, double sum, ClientType type)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.countOfRequests = countOfRequests;
            this.sum = sum;
            this.type = type;
        }
    }
}