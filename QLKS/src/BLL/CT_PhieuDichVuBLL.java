/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BLL;

import DAL.CT_PhieuDichVuDAL;
import DTO.CT_PhieuDichVu;
import DTO.KhachHang;
import DTO.PhieuThuePhong;
import GUI.jpanel_ThuePhong;
import java.awt.event.MouseEvent;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class CT_PhieuDichVuBLL {
    
    CT_PhieuDichVuDAL DAL = new CT_PhieuDichVuDAL();
    //lấy dịch vụ trong phiếu
    public ArrayList<CT_PhieuDichVu> layDichVuTheoPhieu(String maphieu){
        return DAL.layDichVuTheoPhieu(maphieu);
    }
    
    //thêm chi tiết dịch vụ
    public boolean themChiTietDV(String MaPhieuDV, String MaDV, String SoLuong, String ThanhTien){
        return DAL.themChiTietDV(MaPhieuDV, MaDV, SoLuong, ThanhTien);
    }
    
    //xử lí thêm dịch vụ đã có sẵn trong phiếu ORDER
    public boolean themSoLuong(String MaPhieuDV, String MaDV, String SoLuong, String ThanhTien){
        return DAL.themSoLuong(MaPhieuDV, MaDV, SoLuong, ThanhTien);
    }
    
    

    
}
