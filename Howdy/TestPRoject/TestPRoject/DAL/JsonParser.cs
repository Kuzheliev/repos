using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using TestPRoject.Common;

namespace TestPRoject.DAL
{
    public class JsonParser
    {
        private string data = "";

        public JsonParser(string data)
        {
            this.data = data;
        }


        public List<EmployerScores> getDataFromJson()
        {
            var json = JsonSerializer.Deserialize<List<EmployerScores>>(data);



            return json;
        }

    }
}
