using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2_Pruefung_2019_Winter_FA228_FIAE
{
    class Praxis
    {
        //=========================
        // Attribute
        //=========================
        public List<Patient> patienten = new List<Patient>();
        private List<Behandlung> behandlungen = new List<Behandlung>();


        //=========================
        // Methoden
        //=========================
        public List<Patient> getPatient(string name)
        {
            List<Patient> patientMitNameGefunden = new List<Patient>();

            foreach(Patient patient in patienten)
            {
                if(patient.getName() == name)
                {
                    patientMitNameGefunden.Add(patient);
                }
            }

            return patientMitNameGefunden;
        }

        public List<Behandlung> getBehandlungen(string kvNummer)
        {
            List<Behandlung> patientBehandlung = new List<Behandlung>();

            foreach(Behandlung behandlung in behandlungen)
            {
                if(behandlung.getKvNummer() == kvNummer)
                {
                    patientBehandlung.Add(behandlung);   
                }
            }

            return patientBehandlung;
        }

        public int anzBehandlungen(string kvNummer)
        {
            return getBehandlungen(kvNummer).Count;

            //int anzahlBehandlungen = 0;

            //foreach(Behandlung behandlung in behandlungen)
            //{
            //    if(behandlung.getKvNummer() == kvNummer)
            //    {
            //        anzahlBehandlungen++;
            //    }
            //}

            //return anzahlBehandlungen;
        }

        public string zeigePatienten(int anzBehandlungen)
        {
            string patientenMitAnzBehandlungen = string.Empty;

            foreach(Patient patient in patienten)
            {
                if(this.anzBehandlungen(patient.getKvNummer()) >= anzBehandlungen)
                {
                    patientenMitAnzBehandlungen += patient.getName() + " ; ";
                }
            }

            return patientenMitAnzBehandlungen;
        }

        public void addBehandlung(Behandlung b)
        {
            this.behandlungen.Add(b);
        }

        public double ermittleKosten()
        {
            double gesamtKosten = 0;

            foreach(Behandlung behandlung in behandlungen)
            {
                gesamtKosten += behandlung.getKosten();
            }

            return gesamtKosten;
        }
    }
}
