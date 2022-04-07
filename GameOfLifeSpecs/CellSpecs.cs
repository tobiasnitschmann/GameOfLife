using System;
using NUnit.Framework;
using GameOfLife.Models;

namespace GameOfLIfeSpecs;

[TestFixture]
public class CellSpecs
{

  
    [Test]
    public void isCellAlive()
    {
        var target = new Cell(true);
        Assert.That(target.alive, Is.EqualTo(true));
    }

    [Test]
    public void KillCellHandling()
    {
        var target = new Cell(true);
        Assert.That(target.WillExistInNextGen(0), Is.False);
        Assert.That(target.WillExistInNextGen(1), Is.False);
        Assert.That(target.WillExistInNextGen(2), Is.True);
        Assert.That(target.WillExistInNextGen(3), Is.True);
        Assert.That(target.WillExistInNextGen(4), Is.False);
        
        target = new Cell(false);
        Assert.That(target.WillExistInNextGen(0), Is.False);
        Assert.That(target.WillExistInNextGen(1), Is.False);
        Assert.That(target.WillExistInNextGen(2), Is.False);
        Assert.That(target.WillExistInNextGen(3), Is.True);
        Assert.That(target.WillExistInNextGen(4), Is.False);
        
    }


    [Test]
    public void isCellAtPosition()
    {
        var target = new Cell(false);
        Assert.That(target.alive, Is.Not.True);
    }

    [Test]
    public void isBoardInitialized()
    {
        var target = new Board(10, 10);
        target.init();
        Assert.That(target.items.Length, Is.EqualTo(100));
        Assert.That(target.items[0,0].alive, Is.False);
        Assert.That(target.items[9, 9].alive, Is.False);
    }



}