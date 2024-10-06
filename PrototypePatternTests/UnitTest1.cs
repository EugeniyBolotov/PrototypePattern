using PrototypePattern;
using PrototypePattern.Classes;

namespace PrototypePatternTests
{
    public class UnitTest1
    {
        [Fact]
        public void FrutCloneTest()
        {
            Fruit originalFruit = new() { Name = "������", GrowthAreol = "�����" };

            Fruit cloneFruit = (Fruit)originalFruit.Clone();

            Assert.NotSame(originalFruit, cloneFruit);
            Assert.Equal(originalFruit.Name, originalFruit.Name);
            Assert.Equal(originalFruit.GrowthAreol, originalFruit.GrowthAreol);
        }
        [Fact]
        public void FrutMyCloneTest()
        {
            Fruit originalFruit = new() { Name = "������", GrowthAreol = "�����" };

            Fruit cloneFruit = originalFruit.MyClone();

            Assert.NotSame(originalFruit, cloneFruit);
            Assert.Equal(originalFruit.Name, originalFruit.Name);
            Assert.Equal(originalFruit.GrowthAreol, originalFruit.GrowthAreol);
        }
        [Fact]
        public void CytrusCloneTest()
        {
            Cytrus originalFruit = new() { Name = "���������", GrowthAreol = "�������", PeelColor="�������" };

            Cytrus cloneFruit = (Cytrus)originalFruit.Clone();

            Assert.NotSame(originalFruit, cloneFruit);
            Assert.Equal(originalFruit.Name, originalFruit.Name);
            Assert.Equal(originalFruit.GrowthAreol, originalFruit.GrowthAreol);
            Assert.Equal(originalFruit.PeelColor, originalFruit.PeelColor);
        }
        [Fact]
        public void CytrusMyCloneTest()
        {
            Cytrus originalFruit = new() { Name = "���������", GrowthAreol = "�������", PeelColor = "�������" };

            Cytrus cloneFruit = originalFruit.MyClone();

            Assert.NotSame(originalFruit, cloneFruit);
            Assert.Equal(originalFruit.Name, originalFruit.Name);
            Assert.Equal(originalFruit.GrowthAreol, originalFruit.GrowthAreol);
            Assert.Equal(originalFruit.PeelColor, originalFruit.PeelColor);
        }
        [Fact]
        public void OrangeCloneTest()
        {
            Orange originalFruit = new() { Name = "��������", GrowthAreol = "�������", PeelColor = "�������", FruitDiametr = 7 };

            Orange cloneFruit = (Orange)originalFruit.Clone();

            Assert.NotSame(originalFruit, cloneFruit);
            Assert.Equal(originalFruit.Name, originalFruit.Name);
            Assert.Equal(originalFruit.GrowthAreol, originalFruit.GrowthAreol);
            Assert.Equal(originalFruit.PeelColor, originalFruit.PeelColor);
            Assert.Equal(originalFruit.FruitDiametr, originalFruit.FruitDiametr);
        }
        [Fact]
        public void OrangeMyCloneTest()
        {
            Orange originalFruit = new() { Name = "��������", GrowthAreol = "�������", PeelColor = "�������", FruitDiametr = 7 };

            Orange cloneFruit = originalFruit.MyClone();

            Assert.NotSame(originalFruit, cloneFruit);
            Assert.Equal(originalFruit.Name, originalFruit.Name);
            Assert.Equal(originalFruit.GrowthAreol, originalFruit.GrowthAreol);
            Assert.Equal(originalFruit.PeelColor, originalFruit.PeelColor);
            Assert.Equal(originalFruit.FruitDiametr, originalFruit.FruitDiametr);
        }
        [Fact]
        public void TangerineCloneTest()
        {
            Tangerine originalFruit = new() { Name = "���������", GrowthAreol = "�������", PeelColor = "�������", Variety = "�������"};

            Tangerine cloneFruit = (Tangerine)originalFruit.Clone();

            Assert.NotSame(originalFruit, cloneFruit);
            Assert.Equal(originalFruit.Name, originalFruit.Name);
            Assert.Equal(originalFruit.GrowthAreol, originalFruit.GrowthAreol);
            Assert.Equal(originalFruit.PeelColor, originalFruit.PeelColor);
            Assert.Equal(originalFruit.Variety, originalFruit.Variety);
        }
        [Fact]
        public void TangerineMyCloneTest()
        {
            Tangerine originalFruit = new() { Name = "���������", GrowthAreol = "�������", PeelColor = "�������", Variety = "�������" };

            Tangerine cloneFruit = originalFruit.MyClone();

            Assert.NotSame(originalFruit, cloneFruit);
            Assert.Equal(originalFruit.Name, originalFruit.Name);
            Assert.Equal(originalFruit.GrowthAreol, originalFruit.GrowthAreol);
            Assert.Equal(originalFruit.PeelColor, originalFruit.PeelColor);
            Assert.Equal(originalFruit.Variety, originalFruit.Variety);
        }
    }
}