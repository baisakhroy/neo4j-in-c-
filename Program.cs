using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using Neo4jClient;
using Neo4j.Driver.V1;
namespace neo4jandc_
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "abcdefg")))
using (var session = driver.Session()){


            
            string[] nodes = new string[100];
            string[] relations = new string[100];
            string[] word = new string[10];

            string[] chuck = new string[] {"is","with","and"};
            string[] adjectives = new string[] {"friends","loves"};

            int i,j,z,chuckflag=0,adjectivesflag=0;
            int a=0,b=0,m=0;
            int d,e=0;
            int id=1;
            
            // Console.WriteLine("enter node1");
            // node1 = Console.ReadLine();

            // Console.WriteLine("enter node2");
            // node2 = Console.ReadLine();

            // Console.WriteLine("enter relation");
            // relation = Console.ReadLine();
Console.WriteLine(adjectives.Length);
         string s;
         Console.WriteLine("Enter your string");
         s = Console.ReadLine();

         int l = s.Length;
         Console.WriteLine(l);

            
            int k=0;

            // for(i=0;i<l;i++){
            //     if(s[i]==' '){
            //         for(j=index;j<=(i-1);j++){
            //             word = 
            //             k++;
                    
            //     }
            // }

            string[] words = s.Split(" ");
            k=words.Length;
            // Console.WriteLine(k);
            for(i=0;i<k;i++){
                chuckflag=0;
                for(j=0;j<chuck.Length;j++){
                    if(words[i]==chuck[j]){
                        chuckflag++;
                    }
                }
                if (chuckflag==0){
                    //  Console.WriteLine(words[i]);
                     string[] toneo4j = new string[k];
                     toneo4j[m]=words[i];
                     
                     Console.WriteLine(toneo4j[m]);
                     

                        adjectivesflag=0;

                        for(z=0;z<adjectives.Length;z++){
                            
                            if(toneo4j[m]==adjectives[z]){
                                adjectivesflag++;
                                
                            }
                        }
                            if(adjectivesflag==0){

                         nodes[a]=toneo4j[m];
                         Console.WriteLine(nodes[a]);
                         a++;
                        
                        }
                        else{
                            relations[b]=toneo4j[m];
                            Console.WriteLine(relations[b]);
                            b++;
                        }

                        // }
                        

                        
                        m++;


}
// for(e=0;e<b;e++){
//     session.Run("MATCH (a:Dotnet {name:{name1}}) , (b:Dotnet {name:{name2}}) CREATE (a)-[r:"+relations[e]+"]->(b)",
//                 new Dictionary<string, object> { {"name1", nodes[0]} ,  
//                 {"name2", nodes[1]} });
// }


}
for(d=0;d<a;d++){
    Console.WriteLine("x");
session.Run("CREATE (a:Dotnet {name: {name}, id:{id}})",
                new Dictionary<string, object> { {"name", nodes[d]}, {"id", id} });

                if((d+1)%2==0){

                    session.Run("MATCH (a:Dotnet {name:{name1}}) , (b:Dotnet {name:{name2}}) CREATE (a)-[r:"+relations[e]+"]->(b)",
                new Dictionary<string, object> { {"name1", nodes[(d-1)]} ,  
                {"name2", nodes[d]} });

                e++;
                id++;
                }

                        

                }
               
            }
        

//             using (var driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "abcdefg")))
// using (var session = driver.Session())
// {
//                  session.Run("CREATE (a:Dotnet {name: {name}, id:{id}})",
//                 new Dictionary<string, object> { {"name", node1}, {"id", 1} });
                 

//                 session.Run("CREATE (a:Dotnet {name: {name}, id:{id}})",
//                 new Dictionary<string, object> { {"name", node2}, {"id",2 }});

                 

//                 session.Run("MATCH (a:Dotnet {name:{name1}}) , (b:Dotnet {name:{name2}}) CREATE (a)-[r:"+relation+"]->(b)",
//                 new Dictionary<string, object> { {"name1", node1} ,  
//                 {"name2", node2} });

//     var result = session.Run("MATCH (a:Person) WHERE a.name = {name} " +
//                              "RETURN a.name AS name, a.title AS title",
//                              new Dictionary<string, object> { {"name", "Arthur"} });

//     foreach (var record in result)
//     {
//         Console.WriteLine($"{record["title"].As<string>()} {record["name"].As<string>()}");
//     }
// }
        }
    }
}
