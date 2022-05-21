using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace SFLOCATOR
{
    static class Solver
    {
        //Method to solve single line to ground faults
        static public LoopResults SolveLineToGround(LineData data, Complex lxCurrent, Complex lxVoltage, Complex nCurrent, Complex fCurrent)
        {
            //Matrix
            double A = data.Z1.Real * (lxCurrent.Real + data.Kcomplex.Real * nCurrent.Real) - data.Z1.Imaginary * (lxCurrent.Imaginary + data.Kcomplex.Imaginary * nCurrent.Imaginary);
            double B = fCurrent.Real;
            double C = data.Z1.Real * (lxCurrent.Imaginary + data.Kcomplex.Real * nCurrent.Imaginary) + data.Z1.Imaginary * (lxCurrent.Real + data.Kcomplex.Imaginary * nCurrent.Real);
            double D = fCurrent.Imaginary;
            double[,] mLG = { { A, B }, { C, D } };
            Matrix<double> M = Matrix<double>.Build.DenseOfArray(mLG);

            //Vector
            double[] vLG = { lxVoltage.Real, lxVoltage.Imaginary };
            Vector<double> V = Vector<double>.Build.DenseOfArray(vLG);

            //Solution
            Vector<double> X = M.Solve(V);
            return new LoopResults(X[0], X[1]);
        }

        //Method to solve line to line faults
        static public LoopResults SolveLineToLine(LineData data, Complex lxCurrent, Complex lxVoltage, Complex lyCurrent, Complex lyVoltage, Complex fCurrent)
        {
            //Line to line voltage
            Complex lxyVoltage = lxVoltage - lyVoltage;

            //Matrix
            double A = data.Z1.Real * (lxCurrent.Real - lyCurrent.Real) - data.Z1.Imaginary * (lxCurrent.Imaginary - lyCurrent.Imaginary);
            double B = fCurrent.Real;
            double C = data.Z1.Real * (lxCurrent.Imaginary - lyCurrent.Imaginary) + data.Z1.Imaginary * (lxCurrent.Real - lyCurrent.Real);
            double D = fCurrent.Imaginary;
            double[,] mLG = { { A, B }, { C, D } };
            Matrix<double> M = Matrix<double>.Build.DenseOfArray(mLG);

            //Vector
            double[] vLG = { lxyVoltage.Real, lxyVoltage.Imaginary };
            Vector<double> V = Vector<double>.Build.DenseOfArray(vLG);

            //Solution
            Vector<double> X = M.Solve(V);
            return new LoopResults(X[0], X[1]);
        }
    }
}
