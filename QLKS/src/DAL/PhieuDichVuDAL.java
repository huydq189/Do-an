/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.PhieuDichVu;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class PhieuDichVuDAL extends DataAccessHelper {
    
    //Tạo phiếu dịch vụ
    public boolean taoPhieuDichVu(String MaHD,String ngay){
        String SQL = "Insert Into PhieuDichVu(MaHD,TriGia,NgayLap) values("+MaHD+",0,'"+ngay+"')";
        try{
            getConnect();
            Statement st =  conn.createStatement();
            int rs = st.executeUpdate(SQL);
            if(rs>0)
                return true;
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
    
    //Cập nhập phiếu dịch vụ
    public boolean capnhapPhieuDV(String MaHD, String TriGia, String NgayLap){
        String SQL = "Update PhieuDichVu set TriGia="+TriGia+", NgayLap='"+NgayLap+"' where MaHD="+MaHD;
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
    
    
    //Lấy mã phiếu dịch vụ dựa vào mã hóa đơn
    public String layMaPhieuDV(String MaHD){
        String SQL = "Select MaPhieuDV from PhieuDichVu where MaHD="+MaHD;
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("MaPhieuDV");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    
    // xử ly thêm dịch vụ vào phiếu dịch vụ
    public boolean themCTDV(String ma, String tien){
        String SQL = "Update PhieuDichVu Set TriGia=TriGia+"+tien+" Where MaPhieuDV="+ma;
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
    
    //Cập nhập thành tiền của phiếu dịch vụ
    public boolean capnhapTriGia(String ma, String tien){
        String SQL = "Update PhieuDichVu Set TriGia="+tien+" Where MaPhieuDV="+ma;
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
    
    
    //Lấy mã hóa đơn từ mã phiếu dịch vụ
    public String layMaHD(String maPhieuDV){
        String SQL = "Select MaHD from PhieuDichVu where MaPhieuDV="+maPhieuDV;
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("MaHD");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    //Xử lý trả phòng
    public boolean xulyTraPhong(String mahd, String tien, String ngay){
        String SQL = "Update PhieuDichVu Set TriGia="+tien+" , NgayLap='"+ngay+"' where MaHD="+mahd;
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
