using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.FSharp.Core;

namespace pomodoroUnitTest
{
    [TestClass]
    public class SQLDataConnectionUnitTest
    {
        [TestMethod]
        public void TestMethod_entry_per_day()
        {
            // arrange
            int entry_per_day = 2;
            
            // act
            
            // assert
            int actual = Pomodoro.Stat.SQLDataConnection.entry_per_day("2014-05-12 18:00:08");
            Assert.AreEqual(entry_per_day, actual);

        }

        [TestMethod]
        public void TestMethod_entry_num_with_default_description_percent()
        {
            // arrange
            int entry_num = Pomodoro.Stat.SQLDataConnection.entry_num;
            int entry_num_with_default_description = Pomodoro.Stat.SQLDataConnection.entry_num_with_default_description;

            // act
            double expected = (entry_num_with_default_description * 1.0) / (entry_num * 1.0) * 100.0;

            // assert
            double actual = Pomodoro.Stat.SQLDataConnection.entry_num_with_default_description_percent;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod_add()
        {
            // arrange
            int a = 1;
            int b = 4;

            // act
            int expected = a + b;
            
            // assert
            int actual = Pomodoro.Stat.SQLDataConnection.add(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod_increment()
        {
            // arrange
            int a = 1;

            // act
            int expected = a + 1;

            // assert
            int actual = Pomodoro.Stat.SQLDataConnection.increment(a);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod_decrement()
        {
            // arrange
            int a = 1;

            // act
            int expected = a - 1;

            // assert
            int actual = Pomodoro.Stat.SQLDataConnection.decrement(a);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod_concat()
        {
            // arrange
            string a = "Ka";
            string b = "ti";

            // act
            string expected = a + b;

            // assert
            string actual = Pomodoro.Stat.SQLDataConnection.concat(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod_life()
        {
            // arrange
            double life = 42.0;

            // act
            double expected = life;

            // assert
            double actual = Pomodoro.Stat.SQLDataConnection.life;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod_tag_num_by_entry()
        {
            // arrange
            int entryid = 1;
            
            // act
            int expected = 2;

            // assert
            int actual = Pomodoro.Stat.SQLDataConnection.tag_num_by_entry(entryid);
            Assert.AreEqual(expected, actual);

        }
    }
}
