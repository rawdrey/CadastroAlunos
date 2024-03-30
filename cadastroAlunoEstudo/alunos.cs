using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAlunoEstudo
{
    class aluno
    {
        public class aluno
        {
            private string _nome;
            private int _idade;
            private string _telefone;
            private string _cpf;
            private string _mail;
            private string _nomeResponsavel;
            private int _matricula;
            public string nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
            public int idade
            {
                get { return _idade; }
                set { _idade = value; }
            }
public string telefone
            {
                get { return _telefone; }
                set { _telefone = value; }
            }
            public string mail
            {
                get { return _mail; }
                set { _mail = value; }
            }
        public string nomeResponsavel
            {
                get { return _nomeResponsavel; }
                set { _nomeResponsavel = value; }
            }
            public int matricula
            {
                get { return _matricula;}
            }
            public aluno(string nome, int idade, string telefone, string cpf,  string mail,  string nomeResponsavel, int matricula)
            {
                _nome = nome;
                _idade = idade;
                _telefone = telefone;
                _cpf = cpf;
                _mail = mail;
                _nomeResponsavel = nomeResponsavel;
                _matricula = matricula;
            }


        }


}
