using Microsoft.VisualStudio.TestTools.UnitTesting;
using OPDManagementSystem.Models;
using System;

namespace PatientHistoryTest
{
    [TestClass]
    public class UnitTestPatientHistory
    {
        [TestMethod]
        public void TestNumberOfTransaction()
        {
            //Arrange 
            var patient = new Patient(4532, "James", "Smith"); 
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.AreEqual(1, p.NumberOfTransactions()); 
        }

        [TestMethod]
        public void TestTransactionsDetail()
        {
            //Arrange
            var patient = new Patient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.IsTrue(p.CheckTransactionLogAvailability(patient, new DateTime(2014, 12, 26))); 
        }

        [TestMethod]
        public void TestTransactionsDetailForDateNotMatchDate()
        {
            //Arrange
            var patient = new Patient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.IsFalse(p.CheckTransactionLogAvailability(patient, new DateTime(2042, 09, 21)));
        }

        [TestMethod]
        public void TestTransactionsDetailForDiseaseNotMatchDate()
        {
            //Arrange
            var patient = new Patient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            var yellowFever = new Disease("YellowFever", true); 
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.IsFalse(p.CheckTransactionLogAvailability(patient, new DateTime(2042, 09, 21)));
        }

        [TestMethod]
        public void TestTransactionDiseaseLog()
        {
            //Arrange 
            var patient = new Patient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);
            
            // Act 


            //Assert 
        }
    }
}