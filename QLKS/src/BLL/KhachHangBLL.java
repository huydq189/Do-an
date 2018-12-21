/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BLL;

import DAL.KhachHangDAL;
import DTO.KhachHang;
import java.util.ArrayList;
import javax.swing.DefaultComboBoxModel;

/**
 *
 * @author HUY
 */
public class KhachHangBLL {
    KhachHangDAL DAL = new KhachHangDAL();
    public DefaultComboBoxModel getCMNDbyKey(String key){
        return DAL.getCMNDbyKey(key);
    }
    
    //lấy thông tin khách hàng theo cmnd
    public KhachHang getKHbyCMND(String cmnd){
        return DAL.getKHbyCMND(cmnd);
    }
    
    //kiểm tra xem đã là khách hàng hay chưa
    public boolean checkKH(String CMND){
        return DAL.checkKH(CMND);
    }
    
    //thêm khách hàng mới
    public boolean themKH(String cm, String ten, String gioitinh, String diachi){
        return DAL.themKH(cm, ten, gioitinh, diachi);
    }
    
    //lấy mã khách hàng dựa vào CMND
    public String layMaKH(String cmnd){
        return DAL.layMaKH(cmnd);
    }
    
    //lấy thông tin khách hàng bằng mã khách hàng
    public KhachHang layThongTin(String makh){
        return DAL.layThongTin(makh);
    }
    
    //Lấy tên khách hàng dựa vào mã khách hàng
    public String layTen(String makh){
        return DAL.layTen(makh);
    }
    
    
    //Lấy CMDMD dựa vào mã khách hàng
    public String layCMND(String makh){
        return DAL.layCMND(makh);
    }
    
    

    
    //Lấy mã khách hàng dựa vào cmnd
    public String layMaTuCMND(String cmnd){
        return DAL.layMaTuCMND(cmnd);
    }
    
    
}
