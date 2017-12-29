// Problem: https://www.hackerrank.com/challenges/complex-numbers/problem
// Java 7
// Thoughts: Basic complex number operations

import java.util.Scanner;
class Complex {
	private double re, im;

	public Complex(double re, double im) {
        this.re = re;
        this.im = im;
	}

	public Complex add(Complex y) {
        Complex result = new Complex(this.re + y.re, this.im + y.im);
        return result;
	}

	public Complex subtract(Complex y) {
        Complex result = new Complex(this.re - y.re, this.im - y.im);
        return result;
	}

	public Complex multiply(Complex y) {
        double re1 = this.re * y.re;
        double im1 = this.re * y.im;
        double im2 = this.im * y.re;
        double re2 = this.im * y.im * -1; // -1 is the replacement of i squared
        Complex result = new Complex(re1 + re2, im1 + im2);
        return result;
	}

	public Complex divide(Complex y) {
        Complex conjugateY = new Complex(y.re, y.im * -1);
        Complex numerator = multiply(conjugateY);
        double denominator = Math.pow(y.re, 2) + Math.pow(y.im, 2);
        Complex result = new Complex(numerator.re / denominator, numerator.im / denominator);
        return result;
	}

	public Complex mod() {
        double absoluteValue = Math.abs(Math.sqrt(Math.pow(this.re, 2) + Math.pow(this.im, 2)));
        Complex result = new Complex(absoluteValue, 0);
        return result;
	}

	public String toString() {
		return String.format("%.2f%s%.2fi", re, im >= 0 ? "+" : "", im);
	}
}
public class Main {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		double[] re = new double[2], im = new double[2];
		for (int i = 0; i < 2; ++i) {
			re[i] = in.nextDouble();
			im[i] = in.nextDouble();
		}
		Complex x = new Complex(re[0], im[0]), y = new Complex(re[1], im[1]);
		System.out.println(x.add(y));
		System.out.println(x.subtract(y));
		System.out.println(x.multiply(y));
		System.out.println(x.divide(y));
		System.out.println(x.mod());
		System.out.println(y.mod());
	}
}