using OPDManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var disease = new Disease("Cancer", true);
            var disease1 = new Disease("HIV", true);
            var historyInstance = new PatientHistory();
            var p = new NationalPatient(74565, "Tony", "Stark");
            var gaurav = new InternationalPatient(54949, "Gaurav", "Rana");

            Console.WriteLine(gaurav.FirstName+","+ gaurav.LastName+", "
                +gaurav.PatientID+","+gaurav.InsuraceDetail);

            historyInstance.AddPatientTransaction(p, new DateTime(2015, 03, 21), disease);
            Console.WriteLine("Disease: " + historyInstance.ReturnDiseaseLog(p, new DateTime(2015, 03, 21)));

            Console.WriteLine("Testing return patient history: "+
            historyInstance.ReturnPatientDetails(new DateTime(2015, 03, 21), disease)
            .PatientID+", " + historyInstance.ReturnPatientDetails(new DateTime(2015, 03, 21), disease)
            .FirstName + ", " + historyInstance.ReturnPatientDetails(new DateTime(2015, 03, 21), disease)
            .LastName);

            historyInstance.AddPatientTransaction(p, new DateTime(2015, 04, 22), disease1);
            historyInstance.GetAllPatientTransactions();
            Console.WriteLine(historyInstance.NumberOfTransactions());

            historyInstance.RemovePatientTransaction(p, new DateTime(2015, 03, 21));
            historyInstance.GetAllPatientTransactions();
            Console.WriteLine(historyInstance.NumberOfTransactions());
            */

            var p = new InternationalPatient(561, "dveov", "sdvkoero");
            Patient pa = new NationalPatient(); 

            var pm = new PatientManagement();
            pm.AddPatient(p);
            pm.AddPatient(pa); 

            Console.WriteLine(pm.PatientCount());

            //pm.GetAllPatients();  
        }
    }
}
