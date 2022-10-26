/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package business;

import java.text.NumberFormat;

/**
 *
 * @author Zack
 */
public interface BudgetItem {
    public abstract double calcSemesterCost();
    public default String semesterCostFormatted(){
        NumberFormat priceFormatter = NumberFormat.getCurrencyInstance();
        return priceFormatter.format(calcSemesterCost());
    };
}
