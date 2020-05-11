using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Business
{
    public class Fruta
    {
        public int Id { get; set; }

        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        
        

        public List<Fruta> Lista()
        {
            var lista   = new List<Fruta>();
            var frutaDb = new Database.Fruta();
            
                foreach (DataRow row in frutaDb.Lista().Rows)
                {
                var fruta       = new Fruta();
                fruta.Id        = Convert.ToInt32(row["id"]);
                fruta.Nome      = row["nome"].ToString();
                fruta.Descricao = row["descricao"].ToString();
                fruta.Imagem    = row["imagem"].ToString();

                lista.Add(fruta);

            }

            return lista;               
        }

        public static void Excluir(int id)
        {
            new Database.Fruta().Excluir(id);
        }

        public static Fruta  BuscarPorId(int id)
        {
            var fruta = new Fruta();
            var frutaDb = new Database.Fruta();

            foreach (DataRow row in frutaDb.BuscaPorId(id).Rows)
            {
                
                fruta.Id = Convert.ToInt32(row["id"]);
                fruta.Nome = row["nome"].ToString();
                fruta.Descricao = row["descricao"].ToString();
                fruta.Imagem = row["imagem"].ToString();
            }

            return fruta;
        }

        public static object BuscarPorNome(string nome)
        {
            var fruta = new Fruta();
            var frutaDb = new Database.Fruta();

            foreach (DataRow row in frutaDb.BuscaPorNome(nome).Rows)
            {

                fruta.Id = Convert.ToInt32(row["id"]);
                fruta.Nome = row["nome"].ToString();
                fruta.Descricao = row["descricao"].ToString();
                fruta.Imagem = row["imagem"].ToString();
            }

            return fruta;
        }

        public void Save()
        {
            new Database.Fruta().Salvar(this.Id, this.Nome, this.Descricao, this.Imagem);
        }
    }
}
