/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BLL;

import DAL.NhanVienDAL;
import DTO.NhanVien;
import java.util.ArrayList;

/**
 *
 * @author RumIT
 */
public class NhanVienBLL {
    NhanVienDAL DAL  = new NhanVienDAL();
    
    //lấy tất cả nhân viên
    public ArrayList<NhanVien> getAll(){
        return DAL.getAll();
    }
   
    
    
    //Lấy mã nhân viên theo tên
    public String getIDbyName(String ten){
        return DAL.getIDbyName(ten);
    }
    
    //Lấy tên nhân viên theo mã
    public String getNamebyID(String ma){
        return DAL.getNamebyID(ma);
    }
    
    //kiểm tra đăng nhập
    public boolean checkLogin(String ten, String pass){
        return DAL.checkLogin(ten, pass);
    }
          
    //Lấy chức vụ bởi mã nhân viên
    public String layChucVu(String manv){
        return DAL.layChucVu(manv);
    }
}