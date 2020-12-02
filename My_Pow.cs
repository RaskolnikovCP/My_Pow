public double MyPow(double x, int n)
        {

            int m = n * (-1);

            double result = 1;

            if (n >= 0)
            {
                for (int i = 0; i < n; i++)

                {

                    result *= x;

                }

                //result = x;

            }
            else
            {

                for (int j = 0; j < m; j++)
                {

                    result *= x;

                }

                result = 1 / result;

            }

            return result;

        }
