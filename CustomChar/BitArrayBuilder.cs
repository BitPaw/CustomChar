namespace CustomChar
{
    public class BitArrayBuilder
    {
        public string Build(string name, bool[] bitArray)
        {
            int indexCounter = 0;
            string text = " flash unsigned char " + name + "[8] =\n {";            

            foreach (bool bit in bitArray)
            {
                if(indexCounter >= 5)
                {
                    text += ",";
                    indexCounter = 0;
                }

                int value = bit ? 1 : 0;

                if (indexCounter == 0)
                {                    
                   text += "\n   0b" + value;
                }
                else
                {
                    text += value;
                }  

                indexCounter++;
            }

            text += "\n };";

            return text;
        }
    }
}