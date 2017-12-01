
using System.Collections.Generic;
using Xunit;
using DataStructures.Sorting;

namespace UnitTests
{

    public class ComparisonSortTests {
        List<string> testInput;
        List<string> expectedOutput;

        public ComparisonSortTests () {
            testInput = new List<string> () {
                "eesberger0@cornell.edu",
                "gculpan1@japanpost.jp",
                "draxworthy2@addthis.com",
                "pmainstone3@ucsd.edu",
                "rleyband4@storify.com",
                "fkrebs5@yellowpages.com",
                "wforder6@purevolume.com",
                "nlowerson7@phpbb.com",
                "ckrauze8@mozilla.com",
                "egostall9@bbb.org",
                "ssalzbergera@tinyurl.com",
                "hdunphieb@google.co.jp",
                "lmcgaughayc@google.com.au",
                "nlattad@deliciousdays.com",
                "ecribbotte@mozilla.org",
                "khuntef@instagram.com",
                "cbardeg@businesswire.com",
                "tliesh@dagondesign.com",
                "hartindalei@howstuffworks.com",
                "rbabstj@networkadvertising.org",
                "tgannawayk@nytimes.com",
                "jhallsworthl@umn.edu",
                "nparkhousem@netscape.com"
            };

            expectedOutput = new List<string>() {
                "cbardeg@businesswire.com",
                "ckrauze8@mozilla.com",
                "draxworthy2@addthis.com",
                "eesberger0@cornell.edu",
                "ecribbotte@mozilla.org",
                "egostall9@bbb.org",
                "fkrebs5@yellowpages.com",
                "gculpan1@japanpost.jp",
                "hartindalei@howstuffworks.com",
                "hdunphieb@google.co.jp",
                "jhallsworthl@umn.edu",
                "khuntef@instagram.com",
                "lmcgaughayc@google.com.au",
                "nlattad@deliciousdays.com",
                "nlowerson7@phpbb.com",
                "nparkhousem@netscape.com",
                "pmainstone3@ucsd.edu",
                "rbabstj@networkadvertising.org",
                "rleyband4@storify.com",
                "ssalzbergera@tinyurl.com",
                "tgannawayk@nytimes.com",
                "tliesh@dagondesign.com",
                "wforder6@purevolume.com"
            };
        }

        [Fact]
        public void TestBubbleSort () {
            List<string> output = BubbleSort.Sort(this.testInput);

            Assert.Equal(expectedOutput, output);
        }
    }
}