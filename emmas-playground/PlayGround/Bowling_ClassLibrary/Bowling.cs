namespace Bowling_ClassLibrary
{
    public class Bowling
    {
        public static int GetScore(string game)
        {
            var frames = ExtractScoreFrames(game);
            var score = 0;

            for (int i = 0;  i < 10; i++) 
            {
                var frame = frames[i];
                var frameScore = 0;
                var firstNextFrame = "" + frames[i+1];
                var secondNextFrame = "" + frames[i+2];
                foreach (var c in frame)
                {
                    if (char.IsNumber(c))
                    {
                        frameScore += (int)char.GetNumericValue(c);
                    }
                    else
                    {
                        if (c.Equals('/'))
                        {
                            frameScore = 10;
                            if (char.IsNumber(firstNextFrame[0]))
                            {
                                frameScore += (int)char.GetNumericValue(firstNextFrame[0]);
                            }
                            else if (firstNextFrame[0].Equals('X'))
                            {
                                frameScore += 10;
                            }
                        }
                        else if (c.Equals('X'))
                        {
                            frameScore = 10;
                            if (char.IsNumber(firstNextFrame[0]))
                            {
                                if (firstNextFrame[1].Equals('/'))
                                {
                                    frameScore += 10;
                                }
                                else
                                {
                                    frameScore += (int)char.GetNumericValue(firstNextFrame[0]);

                                    if (firstNextFrame.Length == 2)
                                    {
                                        if (char.IsNumber(firstNextFrame[1]))
                                        {
                                            frameScore += (int)char.GetNumericValue(firstNextFrame[1]);
                                        }
                                    }
                                    else
                                    {
                                        if (char.IsNumber(secondNextFrame[0]))
                                        {
                                            frameScore += (int)char.GetNumericValue(secondNextFrame[0]);
                                        }
                                        else if (secondNextFrame[0].Equals('X'))
                                        {
                                            frameScore += 10;
                                        }
                                    }
                                }
                            }
                            else if (firstNextFrame[0].Equals('X'))
                            {
                                frameScore += 10;
                                if (char.IsNumber(secondNextFrame[0]))
                                {
                                    frameScore += (int)char.GetNumericValue(secondNextFrame[0]);
                                }
                                else if (secondNextFrame[0].Equals('X'))
                                {
                                    frameScore += 10;
                                }
                            }
                        }
                    }
                }
                score += frameScore;
            }
            return score;
        }


        private static List<string> ExtractScoreFrames(string game) 
        {
            var frames = new List<string>();
            foreach (var frame in game.Split("|"))
            {
                frames.Add(frame.Replace('-', '0'));
            }
            return frames;
        }
    }
}