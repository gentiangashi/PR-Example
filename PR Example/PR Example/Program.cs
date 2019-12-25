using System;

namespace PR_Example
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        int numberOfFacts = 0;
        Facts FACTS = new Facts();

        void addFACTS()
        {

            FACTS.headache = false;
            FACTS.vomiting = false;
            FACTS.cramp = false;
            FACTS.rash = false;
            FACTS.cough = false;
            FACTS.fatigue = false;
            FACTS.nausea = false;
            FACTS.dizziness = false;
            FACTS.cold = false;
            FACTS.chestPain = false;
            FACTS.infection = false;
            FACTS.flu = false;
            FACTS.healthy = false;
            FACTS.prescribeAntibiotics = false;
            FACTS.prescribePainkillers = false;
            FACTS.gastroenteritis = false;
        }

        private void countFACTS()
        {
            int count = 0;
            foreach (fact in FACTS)
            {
                if (FACTS[fact]) count++;
            }
            return count;
        }

        void printFACTS()
        {
            foreach (fact in FACTS)
            {
                document.write("<p>" + fact + " is " + FACTS[fact] + "<p>");
            }
        }

        private void infer()
        {
            do
            {
                numberOfFacts = countFACTS();
                (FACTS.headache && FACTS.vomiting) ? FACTS.flu = true : FACTS.flu = false;
                FACTS.infection? FACTS.prescribeAntibiotics = true : FACTS.prescribeAntibiotics = false;
                FACTS.headache? FACTS.prescribePainkillers = true : FACTS.prescribePainkillers = false;
                (FACTS.nausea && FACTS.fatigue) ? FACTS.gastroenteritis = true : FACTS.gastroenteritis = false;
                FACTS.infection? FACTS.healthy = true : FACTS.healthy = false;
                FACTS.prescribePainkillers? FACTS.prescribePainkillers = true : FACTS.prescribePainkillers = false;
            }
            while (numberOfFacts != countFACTS())
        }

            addFACTS();
            FACTS.headache = true;
            FACTS.vomiting = true;
            infer();
            ntFACTS();
    }
}
