using System;
using System.Collections.Generic;
using System.Text;

namespace PR_Example
{
    class Facts
    {
        bool Headache;
        bool Vomiting;
        bool Cramp;
        bool Rash;
        bool Cough;
        bool Fatigue;
        bool Nausea;
        bool Dizziness;
        bool Cold;
        bool ChestPain;
        bool Infection;
        bool Flu;
        bool Healthy;
        bool PrescribeAntibiotics;
        bool PrescribePainkillers;
        bool Gastroenteritis;

        public Facts()
        {
            Headache = false;
            Vomiting = false;
            Cramp = false;
            Rash = false;
            Cough = false;
            Fatigue = false;
            Nausea = false;
            Dizziness = false;
            Cold = false;
            ChestPain = false;
            Infection = false;
            Flu = false;
            Healthy = false;
            PrescribeAntibiotics = false;
            PrescribePainkillers = false;
            Gastroenteritis = false;
        }

        public Facts(bool head, bool vomit, bool cram, bool ras, bool coug, bool fatig, bool nause, bool dizzi, bool col, bool chest, bool infect, bool fl, bool health, bool antibio, bool pain, bool gast)
        {
            Headache = head;
            Vomiting = vomit;
            Cramp = cram;
            Rash = ras;
            Cough = coug;
            Fatigue = fatig;
            Nausea = nause;
            Dizziness = dizzi;
            Cold = col;
            ChestPain = chest;
            Infection = infect;
            Flu = fl;
            Healthy = health;
            PrescribeAntibiotics = antibio;
            PrescribePainkillers = pain;
            Gastroenteritis = gast;
        }
        public bool headache
        { get { return Headache; } set { } }

        public bool vomiting
        { get { return Vomiting; } set { } }

        public bool cramp
        { get { return Cramp; } set { } }

        public bool rash
        { get { return Rash; } set { } }

        public bool cough
        { get { return Cough; } set { } }

        public bool fatigue
        { get { return Fatigue; } set { } }

        public bool nausea
        { get { return Nausea; } set { } }

        public bool dizziness
        { get { return Dizziness; } set { } }

        public bool cold
        { get { return Cold; } set { } }

        public bool chestPain
        { get { return ChestPain; } set { } }

        public bool infection
        { get { return Infection; } set { } }

        public bool flu
        { get { return Flu; } set { } }

        public bool healthy
        { get { return Healthy; } set { } }

        public bool prescribeAntibiotics
        { get { return PrescribeAntibiotics; } set { } }

        public bool prescribePainkillers
        { get { return prescribePainkillers; } set { } }

        public bool gastroenteritis
        { get { return Gastroenteritis; } set { } }

    }
}
