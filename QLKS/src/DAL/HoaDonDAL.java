/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.HoaDon;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Vector;

/**
 *
 * @author HUY
 */
public class HoaDonDAL extends DataAccessHelper{
    
    
    //tạo hóa đơn khi vừa tạo phiếu thuê phòng
    public boolean khoiTaoHD(String maphieuthue){
        String SQL = "Insert into HoaDon(MaPhieuThue) values("+maphieuthue+")";
        try{
            getConnect();
            Statement st = conn.createStatement();
            int rs = st.executeUpdate(SQL);
            if(rs>0)
                return true;
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
    
    //Lấy mã hóa đơn từ mã phiếu thuê
    public String getMaHD(String maphieuthue){
        String SQL = "Select MaHD from HoaDon where MaPhieuThue="+maphieuthue;
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null&&rs.next())
                return rs.getString("MaHD");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
    }
        return "";
    }
    
    //Lấy mã phiếu thuê bằng mã hóa đơn
    public String layMaPhieuThue(String maHD){
        String SQL = "Select MaPhieuThue from HoaDon where MaHD="+maHD;
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("MaPhieuThue");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    
    //xử lý trả phongg
    public boolean xulyTraPhong(String mahd, String tienDV, String tienThue, String trigia, String ngay, String manv){
        String SQL = "Update HoaDon set TienDichVu="+tienDV+", TienThuePhong="+tienThue+", TriGia="+trigia+", NgayHD='"+ngay+"', MaNV='"+manv+"' where MaHD="+mahd;
        try{
            getConnect();
            Statement st = conn.createStatement();
            int rs = st.executeUpdate(SQL);
            if(rs > 0)
                return true;
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
    
}
