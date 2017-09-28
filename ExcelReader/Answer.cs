using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReader
{
    class Answer
    {
        public string time;
        public string name;
        public string group;
        public string[] answers = new string[24];

        public Answer[] CheckMatch(Answer[] answers)
        {
            float[] points = new float[answers.Length];
            for(int i = 0; i < answers.Length; i++)
            {
                if((answers[i].answers[0] == "Sim" && this.answers[0] == "Não") || (answers[i].answers[0] == "Não" && this.answers[0] == "Sim"))
                {
                    points[i] += 0.5f;
                }
                if( (answers[i].answers[1] == "Inverno" && this.answers[1] == "Inverno") || (answers[i].answers[1] == "Verão" && this.answers[1] == "Verão") || (answers[i].answers[1] == "Primavera" && this.answers[1] == "Outono") || (answers[i].answers[1] == "Outono" && this.answers[1] == "Primavera"))
                {
                    points[i] += 1;
                }
                else if((answers[i].answers[1] == "Primavera" && this.answers[1] == "Verão") || (answers[i].answers[1] == "Verão" && this.answers[1] == "Primavera") || (answers[i].answers[1] == "Outono" && this.answers[1] == "Inverno") || (answers[i].answers[1] == "Inverno" && this.answers[1] == "Outono"))
                {
                    points[i] += 0.5f;
                }
                if((answers[i].answers[2] == "Habbib's" && this.answers[2] == "Subway") || (answers[i].answers[2] == "Subway" && this.answers[2] == "Habbib's") || (answers[i].answers[2] == "Burger King" && this.answers[2] == "Burger King") || (answers[i].answers[2] == "McDonald's" && this.answers[2] == "Bob's") || (answers[i].answers[2] == "Bob's" && this.answers[2] == "McDonald's") || (answers[i].answers[2] == "KFC" && this.answers[2] == "Burguer King") || (answers[i].answers[2] == "Burguer King" && this.answers[2] == "KFC"))
                {
                    points[i] += 1;
                }
                else if((answers[i].answers[2] == "McDonald's" && this.answers[2] == "Burguer King") || (answers[i].answers[2] == "Burguer King" && this.answers[2] == "McDonald's"))
                {
                    points[i] += 0.5f;
                }
                if((answers[i].answers[3] == "Metro Linha 1" && this.answers[3] == "VLT") || (answers[i].answers[3] == "VLT" && this.answers[3] == "Metro Linha 1") || (answers[i].answers[3] == "BRT" && this.answers[3] == "Metro Linha 2") || (answers[i].answers[3] == "Metro Linha 2" && this.answers[3] == "BRT") || (answers[i].answers[3] == "VLT" && this.answers[3] == "VLT"))
                {
                    points[i] += 1;
                }
                else if((answers[i].answers[3] == "Metro Linha 1" && this.answers[3] == "Metro Linha 2") || (answers[i].answers[3] == "Metro Linha 2" && this.answers[3] == "Metro Linha 1"))
                {
                    points[i] += 0.5f;
                }
                if((answers[i].answers[4] == "Sim" && answers[i].answers[4] == "Não") || (answers[i].answers[4] == "Não" && answers[i].answers[4] == "Sim") || (answers[i].answers[4] == "Irrelevante" && answers[i].answers[4] == "Que?") || (answers[i].answers[4] == "Que?" && answers[i].answers[4] == "Irrelevante"))
                {
                    points[i] += 1f;
                }
            }
            return new Answer[10];
        }
    }
}
