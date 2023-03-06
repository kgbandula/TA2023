using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2023.Pages
{

    public class TMPage
    {
        public void CreateTM(IWebDriver driver) 
        {
            //create new time
            IWebElement createNewBtn = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewBtn.Click();

            //Select type code = time
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]"));
            typeCodeDropdown.Click();

            IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            time.Click();

            //Enter code
            IWebElement codeTxtbox = driver.FindElement(By.Id("Code"));
            codeTxtbox.SendKeys("TAB");

            //Enter description
            IWebElement descriptionTxtbox = driver.FindElement(By.Id("Description"));
            descriptionTxtbox.SendKeys("TAB2023");

            //Enter Price
            IWebElement priceTxtbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTxtbox.SendKeys("109");

            //Save record
            IWebElement saveBtn = driver.FindElement(By.Id("SaveButton"));
            saveBtn.Click();
            Thread.Sleep(2000);

            //Paginate to last record created
            IWebElement gotoLastpageBtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            gotoLastpageBtn.Click();
            Thread.Sleep(3000);

            //Find last record entered
            IWebElement LastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);
        }



        public void EditTM(IWebDriver driver) 
        {
            //Edit button click
            IWebElement editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbtn.Click();

            //click on material dropdown list 
            IWebElement typeCodeDropdownbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]"));
            typeCodeDropdownbox.Click();

            //select material
            IWebElement materialselect = driver.FindElement(By.Id("TypeCode_option_selected"));
            materialselect.Click();

            //edit code
            IWebElement codeTxt = driver.FindElement(By.Id("Code"));
            codeTxt.Click();
            codeTxt.Clear();
            codeTxt.SendKeys("TAB Edit");

            //edit material
            IWebElement descriptionTxt = driver.FindElement(By.Id("Description"));
            descriptionTxt.Click();
            descriptionTxt.Clear();
            descriptionTxt.SendKeys("TAB2023A");
            Thread.Sleep(2000);

            //edit pricePerUnit
            IWebElement priceTB = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));

            IWebElement newPrice = driver.FindElement(By.Id("Price"));
            priceTB.Click();
            newPrice.Click();
            newPrice.Clear();
            priceTB.SendKeys("201");

            //Save edit
            IWebElement savebtn = driver.FindElement(By.Id("SaveButton"));
            savebtn.Click();
            Thread.Sleep(2000);

            //Paginate to lastPage
            IWebElement lastPageBtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageBtn.Click();


            //Find last record edited
            IWebElement LastRecordTxt = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);
        }


        public void DeleteTM(IWebDriver driver) 
        {
            //delete record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1000);

            // Click on ok button
            IAlert al = driver.SwitchTo().Alert();
            al.Accept();
            Thread.Sleep(1000);

        }

    }      
          
}