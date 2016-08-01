using NUnit.Framework;
using ReversedString;

namespace ReversedStringTests
{
    [TestFixture]
    public class ReverseStringTests
    {
        [Test]
        public void SimpleString_IsCorrectlyReversed()
        {
            var actual = "123456".Reverse();
            Assert.AreEqual("654321", actual);
        }

        // String in this test copied from http://generator.lorem-ipsum.info/_chinese
        [Test]
        public void ChineseLibsumString_CorrectlyReversed()
        {
            var actual = "瑽蠈譖磝磢磭".Reverse();
            Assert.AreEqual("磭磢磝譖蠈瑽", actual);
        }

        // Strings in this test copied from http://www.columbia.edu/~fdc/utf8/ 
        // Reversed using http://codebeautify.org/reverse-string
        [Test]
        public void MixedString_CorrectlyReversed()
        {
            var actual = "Testing «ταБЬℓσ»: யாமறிந்த ಬಾ ಇಲ್ಲಿ ಸಂಭವಿಸು ಇಂದೆನ್ನ ಹೃದಯದಲಿ ﻿काचं शक्नोम्यत्तुम्".Reverse();
            Assert.AreEqual("्मुत्तय्मोन्कश ंचाक﻿ ಿಲದಯದೃಹ ನ್ನೆದಂಇ ುಸಿವಭಂಸ ಿಲ್ಲಇ ಾಬ த்நிறமாய :»σℓЬБατ« gnitseT", actual);
        }

        [Test]
        public void AeLigatureWhenReversed_BasedOnUnicodeCharactersNotLetters()
        {
            var actual = "æon".Reverse();
            Assert.AreEqual("noæ", actual);
        }
    }
}
