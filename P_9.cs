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
            int i = 0;
            Polynomial Chastnoe = new Polynomial(new Rational[P_6.Run(A) - P_6.Run(B)]);
            Rational E;
            while (P_6.Run(A) >= P_6.Run(B)) // ����������� ���� ����� ������(�.�. ���� ������� �������� >= ����. ��������)
            {
                E = Q_8.Run(P_5.Run(A), P_5.Run(B));//������� ���������� ��������(�), ������� ����� �������� �� ��������
                Chastnoe.Values[i] = E; // ���������� � ������� ����������
                A = P_2.Run(A, (P_3.Run(B, E)));// �������� �� �������� ������������ � �� ��������. � �������� ���������� ������� ����������.
                i++;
            }
            return Chastnoe;
        }
    }
}