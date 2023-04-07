using Docker.DotNet.Models;
using Mars.Drivers;
using Mars.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Mars.Test
{
    [TestFixture]
    [Parallelizable]
    public class MarsTest : MarsChromeDriver
    {
        MarsLoginPage marsLoginPageObj = new MarsLoginPage();
        MarsProfilePage marsProfilePageObj = new MarsProfilePage();
        MarsShareSkillsPage marsShareSkillPageObj = new MarsShareSkillsPage();

        [Test, Order(1)]
        public void CreateMarsStep()
        {
            // TM Page Object Initialization and Definition

            marsLoginPageObj.MarsNavigateToPortal(driver);
            marsProfilePageObj.MarsAddProfileDetails(driver);
            marsProfilePageObj.MarsAddNewLanguage(driver);
            marsProfilePageObj.MarsAddNewSkill(driver);
            marsProfilePageObj.MarsAddNewEducation(driver);
            marsProfilePageObj.MarsAddNewCertificate(driver);

        }

        [Test, Order(2)]
        public void EditMarsStep()
        {
            marsLoginPageObj.MarsNavigateToPortal(driver);
            marsProfilePageObj.MarsEditLanguage(driver);
            marsProfilePageObj.MarsEditSkill(driver);
            marsProfilePageObj.MarsEditEducation(driver);
            marsProfilePageObj.MarsEditCertificate(driver);

        }
        [Test, Order(3)]

        public void DeleteMarsStep() 
        {
            marsLoginPageObj.MarsNavigateToPortal(driver);
            marsProfilePageObj.MarsDeleteLanguage(driver);
            marsProfilePageObj.MarsDeleteSkills(driver);
            marsProfilePageObj.MarsDeleteEducation(driver);
            marsProfilePageObj.MarsDeleteCertificate(driver);
        }

        [Test, Order(4)]

        public void AddProfileDetails()
        {

            marsLoginPageObj.MarsNavigateToPortal(driver);
            marsProfilePageObj.GoToShareSkillsPage(driver);
            marsShareSkillPageObj.MarsShareSkillsForm(driver);


        }
    }
}