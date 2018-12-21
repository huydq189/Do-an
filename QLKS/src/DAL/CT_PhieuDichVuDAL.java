/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.CT_PhieuDichVu;
import DTO.DichVu;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class CT_PhieuDichVuDAL extends DataAccessHelper{
    
    //lấy dịch vụ trong phiếu
    public ArrayList<CT_PhieuDichVu> layDichVuTheoPhieu(String maphieu){
       ArrayList<CT_PhieuDichVu> temp = new ArrayList<CT_PhieuDichVu>();
       String SQL = "Select TenDV, SoLuong,DonGia,ThanhTien from DichVu,CT_PhieuDichVu where MaPhieuDV="+maphieu+" and DichVu.MaDV=CT_PhieuDichVu.MaDV";
       try{
           getConnect();
           Statement st = conn.createStatement();
           ResultSet rs = st.executeQuery(SQL);
           if(rs!=null)
               while(rs.next()){
                   CT_PhieuDichVu ctdv = new CT_PhieuDichVu();
                   ctdv.setTenDV(rs.getString("TenDV"));
                   ctdv.setDonGia(rs.getString("DonGia"));
                   ctdv.setSoLuong(rs.getString("SoLuong"));
                   ctdv.setThanhTien(rs.getString("ThanhTien"));
                   temp.add(ctdv);
               }
           getClose();
       }catch(Exception e){
           e.printStackTrace();
       }
       return temp;
    }
    
    //thêm dịch vụ
    public boolean themChiTietDV(String MaPhieuDV, String MaDV, String SoLuong, String ThanhTien){
       String SQL = "insert into CT_PhieuDichVu values('"+MaPhieuDV+"','"+MaDV+"','"+SoLuong+"','"+ThanhTien+"')";
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
    
    
    //cập nhập lại số lượng và thành tiền của dịch vụ (khi thêm số lượng dịch vụ trong order)
    public boolean themSoLuong(String MaPhieuDV, String MaDV, String SoLuong, String ThanhTien){
        String SQL = "Update CT_PhieuDichVu Set SoLuong=SoLuong+"+SoLuong+", ThanhTien=ThanhTien+"+ThanhTien+" where MaPhieuDV="+MaPhieuDV+" and MaDV='"+MaDV+"'";
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
