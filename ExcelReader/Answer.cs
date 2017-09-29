using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReader
{
    class Points
    {
        public float value;
        public string person;
    }
    class Answer
    {
        public string time;
        public string name;
        public string group;
        public string[] answers = new string[24];

        public Points[] CheckMatch(Answer[] answers)
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
                if((answers[i].answers[4] == "Sim" && this.answers[4] == "Não") || (answers[i].answers[4] == "Não" && this.answers[4] == "Sim") || (answers[i].answers[4] == "Irrelevante" && this.answers[4] == "Que?") || (answers[i].answers[4] == "Que?" && this.answers[4] == "Irrelevante"))
                {
                    points[i] += 1f;
                }
                if ((answers[i].answers[5] == "Tempestade" && this.answers[5] == "Wolverine") || (answers[i].answers[5] == "Wolverine" && this.answers[5] == "Tempestade") || (answers[i].answers[4] == "Fênix (Jean Grey)" && this.answers[4] == "Ciclope (Scott Summers)") || (answers[i].answers[4] == "Ciclope (Scott Summers)" && this.answers[4] == "Fênix (Jean Grey)") || (answers[i].answers[4] == "Magneto" && this.answers[4] == "Professor Xavier") || (answers[i].answers[4] == "Professor Xavier" && this.answers[4] == "Magneto") || (answers[i].answers[4] == "Noturno" && this.answers[4] == "Vampira") || (answers[i].answers[4] == "Vampira" && this.answers[4] == "Noturno"))
                {
                    points[i] += 1f;
                }
                else if((answers[i].answers[5] == "Ciclope (Scott Summers)" && this.answers[5] == "Wolverine") || (answers[i].answers[5] == "Wolverine" && this.answers[5] == "Ciclope (Scott Summers)") || (answers[i].answers[5] == "Noturno" && this.answers[5] == "Lince Negra") || (answers[i].answers[5] == "Lince Negra" && this.answers[5] == "Noturno") || (answers[i].answers[5] == "Magneto" && this.answers[5] == "Mística") || (answers[i].answers[5] == "Mística" && this.answers[5] == "Magneto"))
                {
                    points[i] += 0.75f;
                }
                else if((answers[i].answers[5] == "Wolverine" && this.answers[5] == "Fênix (Jean Grey)") || (answers[i].answers[5] == "Fênix (Jean Grey)" && this.answers[5] == "Wolverine") || (answers[i].answers[5] == "Mística" && this.answers[5] == "Wolverine") || (answers[i].answers[5] == "Wolverine" && this.answers[5] == "Mística") || (answers[i].answers[5] == "Professor Xavier" && this.answers[5] == "Mística") || (answers[i].answers[5] == "Mística" && this.answers[5] == "Professor Xavier"))
                {
                    points[i] += 0.5f;
                }
                if((answers[i].answers[6] == "Juliana Potengy" && this.answers[6] == "Juliana Potengy") || (answers[i].answers[6] == "Thais Dutra" && this.answers[6] == "Thais Dutra") || (answers[i].answers[6] == "Andressa Alves" && this.answers[6] == "Ana Julia Borges") || (answers[i].answers[6] == "Ana Julia Borges" && this.answers[6] == "Andressa Alves"))
                {
                    points[i] += 1f;
                }
                else if((answers[i].answers[6] == "Juliana Potengy" && this.answers[6] == "Evelyn Correa") || (answers[i].answers[6] == "Evelyn Correa" && this.answers[6] == "Juliana Potengy") || (answers[i].answers[6] == "Juliana Potengy" && this.answers[6] == "Eduarda Helena") || (answers[i].answers[6] == "Eduarda Helena" && this.answers[6] == "Juliana Potengy"))
                {
                    points[i] += 0.5f;
                }
                if(answers[i].answers[7] == this.answers[7])
                {
                    points[i] += 1f;
                }
                if(answers[i].answers[8] == this.answers[8])
                {
                    points[i] += 1f;
                }
                if((answers[i].answers[9] == "Sorriso" && this.answers[9] == "Olhos") || (answers[i].answers[9] == "Olhos" && this.answers[9] == "Sorriso") || (answers[i].answers[9] == "Cabelo" && this.answers[9] == "Cabelo"))
                {
                    points[i] += 1f;
                }
                if((answers[i].answers[10] ==  this.answers[10]))
                {
                    points[i] += 1f;
                }
                if((answers[i].answers[11] == this.answers[11]))
                {
                    points[i] += 1f;
                }
                if((answers[i].answers[12] == "Cachorro" && this.answers[12] == "Cobra") || (answers[i].answers[12] == "Cobra" && this.answers[12] == "Cachorro") || (answers[i].answers[12] == "Hamster" && this.answers[12] == "Gato") || (answers[i].answers[12] == "Gato" && this.answers[12] == "Hamster") || (answers[i].answers[12] == "Tartaruga" && this.answers[12] == "Pássaro") || (answers[i].answers[12] == "Pássaro" && this.answers[12] == "Tartaruga"))
                { 
                    points[i] += 1f;
                }
                if((answers[i].answers[13] ==  this.answers[13]))
                {
                    points[i] += 1f;
                }
                else if((answers[i].answers[13] == "Tarde" && (this.answers[13] == "Noite" || this.answers[13] == "Manhã")) || (this.answers[13] == "Tarde" && (answers[i].answers[13] == "Noite" || answers[i].answers[13] == "Manhã")))
                {
                    points[i] += 0.5f;
                }
                if((answers[i].answers[14] == "Ver séries" && this.answers[14] == "Ler livros") || (answers[i].answers[14] == "Ler livros" && this.answers[14] == "Ver séries") || (answers[i].answers[14] == "Esportes" && this.answers[14] == "Sair com amigos") || (answers[i].answers[14] == "Sair com amigos" && this.answers[14] == "Esportes") || (answers[i].answers[14] == "Esportes" && this.answers[14] == "Sair com amigos") || (answers[i].answers[14] == "Sair com amigos" && this.answers[14] == "Sair com amigos"))
                { 
                    points[i] += 1f;
                }
                if((answers[i].answers[15] == this.answers[15]))
                {
                    points[i] += 1f;
                }
                if ((answers[i].answers[16] == this.answers[16]))
                {
                    points[i] += 1f;
                }
                if((answers[i].answers[17] == this.answers[17]))
                {
                    points[i] += 1f;
                }
            }
            Points[] result = new Points[points.Length];
            for (int i  = 0; i < points.Length; i++)
            {
                result[i].value = points[i];
                result[i].person = answers[i].name;
            }
            result = BubbleSort(result);
            return result;
        }
        public static Points[] BubbleSort(Points[] arrayToBeSorted)
        {
            Points auxNumber;
            for (int i = 0; i < arrayToBeSorted.Length; i++)
            {
                for (int j = 0; j < arrayToBeSorted.Length - 1; j++)
                {
                    if (arrayToBeSorted[j].value > arrayToBeSorted[j + 1].value)
                    {
                        auxNumber = arrayToBeSorted[j];
                        arrayToBeSorted[j] = arrayToBeSorted[j + 1];
                        arrayToBeSorted[j + 1] = auxNumber;
                    }
                }
            }
            return arrayToBeSorted;
        }
    }
}
