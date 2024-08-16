using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class AddTest 
{
   [Test]
   public void AddTestSimplePasses()
   {
      // Arrange
      int a = 1;
      int b = 2;
      int expected = 3;
      // Act
      int result = a + b;
      // Assert
      Assert.AreEqual(expected, result);
   }
}
