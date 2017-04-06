namespace DiskMat
{
    /// <summary>
    /// ������� �� ������� �����������.
    /// �������� ������
    /// </summary>
    static class P_9
    {
        /// <summary>
        /// ������� ������� �� ������� �����������
        /// </summary>
        /// <param name="A">�������</param>
        /// <param name="B">��������</param>
        /// <returns>�������</returns>
        public static Polynomial Run(Polynomial A, Polynomial B)
        {
            int i = A.Values.Length - B.Values.Length+1;
            Polynomial Chastnoe = new Polynomial(new Rational[i]);
            Rational E;
            while (A.Values.Length >= B.Values.Length) // ����������� ���� ����� ������(�.�. ���� ������� �������� >= ����. ��������)
            {
                E = Q_8.Run(P_5.Run(A), P_5.Run(B));//������� ���������� ��������(�), ������� ����� �������� �� ��������
                Chastnoe.Values[i-1] = E; // ���������� � ������� ����������
                A = P_2.Run(A, P_4.Run((P_3.Run(B, E)), A.Values.Length - B.Values.Length));// �������� �� �������� ������������ � �� ��������. � �������� ���������� ������� ����������.
                i--;
            }
            return Chastnoe;
        }
    }
}