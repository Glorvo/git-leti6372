namespace DiskMat
{
    /// <summary>
    /// ������� �� ������� �����������
    /// �������� ������
    /// </summary>
    static class P_10
    {
        /// <param name="A">�������</param>
        /// <param name="B">��������</param>
        /// <returns>�������</returns>
        public static Polynomial Run(Polynomial A, Polynomial B)
        {
            int i = A.Values.Length;
            Polynomial C = new Polynomial(new Rational[i]);
            C = A;
            Rational E;
            while (A.Values.Length >= B.Values.Length)   // ����������� ���� ����� ������(�.�. ���� ������� �������� >= ����. ��������)
            {
                E = Q_8.Run(P_5.Run(A), P_5.Run(B));  //������� ���������� ��������(�), ������� ����� �������� �� ��������
                C = P_4.Run((P_3.Run(B, E)), A.Values.Length - B.Values.Length);
                A = P_2.Run(A, C);   // �������� �� �������� ������������ � �� ��������. � �������� ���������� ������� ����������.
            }
            return A; // ����� ����� �������� ��������� ������� �� ������� �� ��������(�.�. �������)
        }
    }
}