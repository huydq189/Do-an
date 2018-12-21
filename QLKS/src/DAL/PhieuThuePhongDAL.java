/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.PhieuThuePhong;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class PhieuThuePhongDAL extends DataAccessHelper {
    
    //Ghi phiếu thuê phòng mới
    public boolean themPhieuMoi(String maphong, String makh, String soLuong, String ngoaiquoc, String manv, String ngayBD, String ngayKT){
        String SQL = "insert into PHIEUTHUEPHONG(MaPhong,MaKh,SoLuongKH,KhachNuocNgoai,NgayBDThue,NgayKTThue,MaNV,TinhTrangPhieu) values('"+maphong+"','"+makh+"',"+soLuong+","+ngoaiquoc+",'"+ngayBD+"','"+ngayKT+"','"+manv+"','1')";
        try{
            getConnect();
            Statement st = conn.createStatement();
            int rs =  st.executeUpdate(SQL);
            if(rs>0)
                return true;
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
    
    //lấy thông tin phiếu thuê phòng - dựa vào mã phòng và trạng thái 1(đang cho thuê)
    public PhieuThuePhong getInfo(String maphong, String  trangthai){
        String SQL = "Select * from PhieuThuePhong where MaPhong='"+maphong+"' and TinhTrangPhieu="+trangthai;
        PhieuThuePhong temp =  new  PhieuThuePhong();
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null&&rs.next()){
                temp.setMaPhong(rs.getString("MaPhong"));
                temp.setMaKH(rs.getString("MaKH"));
                temp.setSoLuongKH(rs.getString("SoLuongKH"));
                temp.setKHNgoaiQuoc(rs.getString("KhachNuocNgoai"));
                temp.setNgayBD(rs.getString("NgayBDThue"));
                temp.setNgayKTThue(rs.getString("NgayKTThue"));
                temp.setMaNV(rs.getString("MaNV"));
            }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
        
    //Lấy mã phiếu thuê phòng mới nhất ứng với phòng 
    public String getMaPhieuMoi(String MaPhong){
        String SQL = "Select MaPhieuThue from PhieuThuePhong where MaPhong='"+MaPhong+"' and TinhTrangPhieu=1";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null&&rs.next())
                return rs.getString("MaPhieuThue");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    
    //lấy thông tin phiếu thuê bằng mã phiếu thuê
    public PhieuThuePhong layThongTin(String maphieu){
        String SQL = "Select MaPhong, MaKH,NgayBDThue,NgayKTthue,KhachNuocNgoai,SoLuongKH from PhieuThuePhong where MaPhieuThue="+maphieu;
        PhieuThuePhong phieu = new PhieuThuePhong();
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next()){
                phieu.setMaPhong(rs.getString("MaPhong"));
                phieu.setMaKH(rs.getString("MaKH"));
                phieu.setSoLuongKH(rs.getString("SoLuongKH"));
                phieu.setKHNgoaiQuoc(rs.getString("KhachNuocNgoai"));
                phieu.setNgayBD(rs.getString("NgayBDThue"));
                phieu.setNgayKTThue(rs.getString("NgayKTThue"));
            }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }        
        return phieu;
    }
    
    
    //Xử lí trả phòng
    public boolean xulyTraPhong(String maphieu, String ngayKT){
        String SQL = "Update PhieuThuePhong Set NgayKTThue='"+ngayKT+"', TinhTrangPhieu=0 where MaPhieuThue="+maphieu;
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
    
    //Lấy danh sách mã phiếu thuê ứng với makh
    public ArrayList<String> layDSMaPhieuThue(String makh){
        ArrayList<String> temp = new ArrayList<>();
        String SQL = "Select MaPhieuThue from PhieuThuePhong where MaKH="+makh;
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null)
                while(rs.next()){
                    temp.add(rs.getString("MaPhieuThue"));
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
    
    //Sửa mã khách hàng thành mã khách ảo của tất cả phiếu thuê của khách hàng này
    public boolean suaMaKH(String maKHao, String maKH){
        String SQL = "Update PhieuThuePhong set MaKH="+maKHao+" where MaKH="+maKH;
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
}
