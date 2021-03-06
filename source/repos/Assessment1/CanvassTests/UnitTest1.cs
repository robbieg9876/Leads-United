using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Assessment1;
using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace CanvassTests
{
    
    [TestClass]
    public class UnitTest1 {
        //Initialises bitmap with set size
        Bitmap OutputBitMap = new Bitmap(871, 548);

        //Makes an instance of the Canvass class
        readonly Canvass Test;
        public UnitTest1()
        {
            //Sets graphics up on bitmap
            Test = new Canvass(Graphics.FromImage(OutputBitMap));
        }

        [TestMethod]
        public void MoveToTest()
        {
            //Sets integer variables
            int toX = 250;
            int toY = 250;
            //Passes values as parameters to Test.MoveTo
            Test.MoveTo(toX, toY);
            //Checks if the statements are true as expected
            Assert.IsTrue(toX == Test.xPos);
            Assert.IsTrue(toY ==Test.yPos);
        }

        [TestMethod]
        public void DrawToTest()
        {
            //Sets integer variables
            int toX = 250;
            int toY = 250;
            //Passes values as parameters to Test.MoveTo
            Test.DrawTo(toX, toY);
            //Checks if the statements are true as expected
            Assert.IsTrue(toX == Test.xPos);
            Assert.IsTrue(toY == Test.yPos);
        }

        [TestMethod]
        public void PenColourCheck()
        {
            //Sets integer variables
           Color colour = Color.Red;
            //Passes values as parameters to Test.MoveTo
            Test.PenColour(colour);
            //Checks if the statements are true as expected
            Assert.AreEqual(colour, Test.Pen.Color);
            
        }
        [TestMethod]
        public void ResetPenTest()
        {
            //Sets integer variables
            int toX = 0;
            int toY = 0;
            //Passes values as parameters to Test.MoveTo
            Test.resetPenPosition();
            //Checks if the statements are true as expected
            Assert.IsTrue(toX == Test.xPos);
            Assert.IsTrue(toY == Test.yPos);
        }

        [TestMethod]
        public void FillOnTest()
        {
            //Sets integer variables
            Boolean fill = true;
            //Checks if the statements are true as expected
            Test.FillShape(fill);

            Assert.AreEqual(fill,Test.Fill);
        }
        [TestMethod]
        public void FillOffTest()
        {
            //Sets integer variables
            Boolean fill = false;
            //Checks if the statements are true as expected
            Test.FillShape(fill);

            Assert.AreEqual(fill, Test.Fill);
        }

        [TestMethod]
        public void DrawSquareTest()
        {
            //Sets integer variables
            int width = 50;
            int toX = Test.xPos;
            int toY = Test.yPos;
            //Passes values as parameters to Test.MoveTo
            Test.DrawSquare(width);
            //Checks if the statements are true as expected
            //Checks drawing position has not changed
            Assert.IsTrue(toX == Test.xPos);
            Assert.IsTrue(toY == Test.yPos);
            //Checks shape is the same size as expected
            Assert.IsTrue(toX + width == Test.xPos + width);
            Assert.IsTrue(toY + width == Test.yPos + width);
        }
        [TestMethod]
        public void DrawCircleTest()
        {
            //Sets integer variables
            int radius = 50;
            int toX = Test.xPos;
            int toY = Test.yPos;
            //Passes values as parameters to Test.MoveTo
            Test.DrawCircle(radius);
            //Checks if the statements are true as expected
            //Checks drawing position has not changed
            Assert.IsTrue(toX == Test.xPos);
            Assert.IsTrue(toY == Test.yPos);
            //Checks shape is the same size as expected
            Assert.IsTrue(toX + radius == Test.xPos + radius);
            Assert.IsTrue(toY + radius == Test.yPos + radius);
            Assert.IsTrue(toX - radius == Test.xPos - radius);
            Assert.IsTrue(toY - radius == Test.yPos - radius);
        }
        [TestMethod]
        public void DrawTriangleTest()
        {
            //Sets integer variables
            int width = 50;
            int height = 150;
            int toX = Test.xPos;
            int toY = Test.yPos;
            //Passes values as parameters to Test.MoveTo
            Test.DrawTriangle(width,height);
            //Checks if the statements are true as expected
            //Checks drawing position has not changed
            Assert.IsTrue(toX == Test.xPos);
            Assert.IsTrue(toY == Test.yPos);
            //Checks shape is the same size as expected
            Assert.IsTrue(toX + width == Test.xPos + width);
            Assert.IsTrue(toY + height == Test.yPos + height);
        }
        [TestMethod]
        public void DrawRectangleTest()
        {
            //Sets integer variables
            int width = 50;
            int height = 150;
            int toX = Test.xPos;
            int toY = Test.yPos;
            //Passes values as parameters to Test.MoveTo
            Test.DrawRectangle(width, height);
            //Checks if the statements are true as expected
            //Checks drawing position has not changed
            Assert.IsTrue(toX == Test.xPos);
            Assert.IsTrue(toY == Test.yPos);
            //Checks shape is the same size as expected
            Assert.IsTrue(toX + width == Test.xPos + width);
            Assert.IsTrue(toY + height == Test.yPos + height);
        }
        [TestMethod]
        public void InitializeVariableTest()
        {
            String variableName = "Test";
            int value = 50;
            //Passes values as parameters to Test.MoveTo
            Test.InitaliseVariable(variableName, value);
            
            //Checks shape is the same size as expected
            Assert.IsTrue(variableName == Test.CurrentVariableName);
            Assert.IsTrue(value == Test.CurrentVariableValue);
        }
        [TestMethod]
        public void LoopTest()
        {
            int startLine = 10;
            int endLine = 15;
            //Passes values as parameters to Test.MoveTo
            Test.Loop(startLine, endLine);

            //Checks shape is the same size as expected
            Assert.IsTrue(startLine == Test.StartLine);
            Assert.IsTrue(endLine == Test.EndLine);
        }
        [TestMethod]
        public void IfStatementTest()
        {
            int startLine = 10;
            int endLine = 15;
            //Passes values as parameters to Test.MoveTo
            Test.IfStatement(startLine, endLine);

            //Checks shape is the same size as expected
            Assert.IsTrue(startLine == Test.StartLine);
            Assert.IsTrue(endLine == Test.EndLine);
        }
        [TestMethod]
        public void MethodsTest()
        {
            string methodName = "MyMethod";
            string[] Parameters = new string [100];
            Parameters.Append("188");
            Parameters.Append("200");
            Parameters.Append("300");
            //Passes values as parameters to Test.MoveTo
            Test.Methods(methodName, Parameters);

            //Checks shape is the same size as expected
            Assert.IsTrue(methodName.Equals(Test.CurrentMethodName));
            Assert.AreEqual(Parameters[0], Test.CurrentParameters[0]);
            Assert.AreEqual(Parameters[1], Test.CurrentParameters[1]);
            Assert.AreEqual(Parameters[2], Test.CurrentParameters[2]);
        }
    }
}
