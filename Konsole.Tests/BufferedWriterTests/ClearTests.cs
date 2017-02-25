﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Konsole.Tests.BufferedWriterTests
{
    public class ClearTests
    {
        [Test]
        public void Should_clear_the_buffer()
        {
            // #ADH 17-02-25 I'm aware this test is currently failing, hope to have this fixed in next commit.
            var con = new BufferedWriter(10,2);
            con.WriteLine("one       ");
            con.WriteLine("two       ");
            Assert.AreEqual(new [] { "one       ", "two       "}, con.Buffer);
            con.Clear();
            Assert.AreEqual(new[] { "          ", "          " }, con.Buffer);
        }

        [Test]
        public void Should_reset_the_y_position()
        {
            var con = new BufferedWriter(10, 2);
            Assert.AreEqual(0,con.Y);
            con.WriteLine("one       ");
            con.WriteLine("two       ");
            Assert.AreEqual(2, con.Y);
            con.Clear();
            Assert.AreEqual(0, con.Y);
        }
    }
}