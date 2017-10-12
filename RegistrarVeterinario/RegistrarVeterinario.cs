﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace RegistrarVeterinario
{
    [TestClass]
    public class RegistrarVeterinario
    {
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void registrarVeterinario_FlujoBasico()
        {
            try
            {
                string mensajeEsperado = "Usuario creado";
                driver.Navigate().GoToUrl("http://petprojectwebapp.azurewebsites.net/User/Register");

                IWebElement input1 = driver.FindElement(By.Name("Firstname"));
                input1.Clear();
                input1.SendKeys("Ramon");

                IWebElement input2 = driver.FindElement(By.Name("Lastname"));
                input2.Clear();
                input2.SendKeys("Ramon");

                IWebElement input3 = driver.FindElement(By.Name("RUC"));
                input3.Clear();
                input3.SendKeys("112233449");

                IWebElement input4 = driver.FindElement(By.Name("Phone"));
                input4.Clear();
                input4.SendKeys("938151132");

                IWebElement input5 = driver.FindElement(By.Name("LicenseCode"));
                input5.Clear();
                input5.SendKeys("132");

                IWebElement input6 = driver.FindElement(By.Name("LicenseDate"));
                input6.Clear();
                input6.SendKeys("25/05/12");

                IWebElement input7 = driver.FindElement(By.Name("Email"));
                input7.Clear();
                input7.SendKeys("ramon69@gmail.com");

                IWebElement input8 = driver.FindElement(By.Name("Password"));
                input8.Clear();
                input8.SendKeys("123456");

                IWebElement btnRegistrar = driver.FindElement(By.Id("Register"));
                btnRegistrar.Click();
                Thread.Sleep(2000);

                string mensajeObtenido = driver.FindElement(By.Id("messages")).Text;
                Assert.AreEqual(mensajeEsperado, mensajeObtenido);
                driver.Close();
            }

            catch (Exception e)
            {
                Assert.Fail();

            }

        }

        [TestMethod]
        public void registrarVeterinario_FlujoAlternativo1()
        {
            try
            {
                string mensajeEsperado = "Datos mal ingresados";
                driver.Navigate().GoToUrl("http://petprojectwebapp.azurewebsites.net/User/Register");

                IWebElement input1 = driver.FindElement(By.Name("Firstname"));
                input1.Clear();
                input1.SendKeys("Ramon");

                IWebElement input2 = driver.FindElement(By.Name("Lastname"));
                input2.Clear();
                input2.SendKeys("Ramon");

                IWebElement input3 = driver.FindElement(By.Name("RUC"));
                input3.Clear();
                input3.SendKeys("112233449");

                IWebElement input4 = driver.FindElement(By.Name("Phone"));
                input4.Clear();
                input4.SendKeys("938151132");

                IWebElement input5 = driver.FindElement(By.Name("LicenseCode"));
                input5.Clear();
                input5.SendKeys("132");

                IWebElement input6 = driver.FindElement(By.Name("LicenseDate"));
                input6.Clear();
                input6.SendKeys("25/05/12");

                IWebElement input7 = driver.FindElement(By.Name("Email"));
                input7.Clear();
                input7.SendKeys("ramon69@gmail.com");

                IWebElement input8 = driver.FindElement(By.Name("Password"));
                input8.Clear();
                input8.SendKeys("ramon69@gmail.com");

                IWebElement btnRegistrar = driver.FindElement(By.Id("Register"));
                btnRegistrar.Click();
                Thread.Sleep(2000);

                string mensajeObtenido = driver.FindElement(By.Id("messages")).Text;
                Assert.AreEqual(mensajeEsperado, mensajeObtenido);
                driver.Close();
            }

            catch (Exception e)
            {
                Assert.Fail();

            }

        }

        [TestMethod]
        public void registrarVeterinario_FlujoAlternativo2()
        {
            try
            {
                string mensajeEsperado = "Datos mal incompletos";
                driver.Navigate().GoToUrl("http://petprojectwebapp.azurewebsites.net/User/Register");

                IWebElement input1 = driver.FindElement(By.Name("Firstname"));
                input1.Clear();
                input1.SendKeys("");

                IWebElement input2 = driver.FindElement(By.Name("Lastname"));
                input2.Clear();
                input2.SendKeys("");

                IWebElement input3 = driver.FindElement(By.Name("RUC"));
                input3.Clear();
                input3.SendKeys("");

                IWebElement input4 = driver.FindElement(By.Name("Phone"));
                input4.Clear();
                input4.SendKeys("");

                IWebElement input5 = driver.FindElement(By.Name("LicenseCode"));
                input5.Clear();
                input5.SendKeys("");

                IWebElement input6 = driver.FindElement(By.Name("LicenseDate"));
                input6.Clear();
                input6.SendKeys("");

                IWebElement input7 = driver.FindElement(By.Name("Email"));
                input7.Clear();
                input7.SendKeys("");

                IWebElement input8 = driver.FindElement(By.Name("Password"));
                input8.Clear();
                input8.SendKeys("");

                IWebElement btnRegistrar = driver.FindElement(By.Id("Register"));
                btnRegistrar.Click();
                Thread.Sleep(2000);

                string mensajeObtenido = driver.FindElement(By.Id("messages")).Text;
                Assert.AreEqual(mensajeEsperado, mensajeObtenido);
                driver.Close();
            }

            catch (Exception e)
            {
                Assert.Fail();

            }

        }


    }

    }
}
