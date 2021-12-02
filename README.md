
# Geometric And Arithmetic Progression Test
## Execution speed test of each method type
![This is an image](https://github.com/laelMatos/GeometricAndArithmeticProgressionTest/blob/master/TestSpeed.JPG)
```
        public static bool IsGeometric(int[] arr)
        {
            var Sn = arr.Sum(x => x);
            var r = arr[1] - arr[0];
            int n = arr.Length;

            return Sn == (arr[0] * (Math.Pow(r , n) -1))/(r-1);
        }
        public static bool IsArithmetic(int[] arr)
        {
            var Sn = arr.Sum(x => x);
            var r = arr[1] - arr[0];
            int n = arr.Length;

            return Sn == ((arr[0] + arr[n-1] )*n) / 2;
        }

        public static bool IsGeometricFast(int[] arr)
        {
            if (arr.Length < 2)
                return true;

            try
            {
                var r = arr[1] / arr[0];
                int aux;

                for (int i = 1; i <= arr.Length - 2; i++)
                {
                    if (r != 0)
                    {
                        aux = arr[i + 1] / arr[i];
                    }
                    else
                    {
                        return false;
                    }
                    if (r != aux)
                        return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool IsArithmeticFast(int[] arr)
        {
            if (arr.Length < 2)
                return true;
            try
            {
                var r = arr[1] - arr[0];
                int aux;

                for (int i = 1; i <= arr.Length - 2; i++)
                {
                    if (r != 0)
                    {
                        aux = arr[i + 1] - arr[i];
                    }
                    else
                    {
                        return false;
                    }
                    if (r != aux)
                        return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
```
