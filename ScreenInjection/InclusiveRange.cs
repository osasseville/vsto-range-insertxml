using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace ScreenInjection
{
    /// <summary>
    /// Prevent range to include partial paragraph.
    /// </summary>
    class InclusiveRange
    {
        private Word.Range inclusiveRange;

        public InclusiveRange(Word.Range range)
        {
            inclusiveRange = MakeInclusive(range);
        }

        private Word.Range MakeInclusive(Word.Range range)
        {
            var firstP = range.Paragraphs.First;
            var lastP = range.Paragraphs.Last;
            while (firstP != null && firstP.Range.Tables.Count > 0)
            {
                firstP = firstP.Next();
            }
            while (lastP != null && (lastP.Range.Tables.Count > 0 ||
                  (lastP.Next() != null && lastP.Next().Range.Tables.Count > 0)))
            {
                lastP = lastP.Previous();
            }

            if (lastP != null && firstP != null && firstP.Range.Start < lastP.Range.End)
            {
                return range.Document.Range(firstP.Range.Start, lastP.Range.End);
            }
            else
            {
                return null;
            }
        }

        public Word.Range Range
        {
            get
            {
                return inclusiveRange;
            }
        }
    }
}
