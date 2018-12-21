/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Binding;

import DTO.CT_PhieuDichVu;
import DTO.DichVu;
import DTO.HoaDon;
import DTO.KhachHang;
import DTO.LoaiPhong;
import DTO.NhanVien;
import DTO.PhieuDichVu;
import DTO.Phong;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Vector;
import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author HUY
 */
public class ControlFormat {
    
    // đổ dữ liệu Phòng lấy lên vào bảng
    public void bindingPhong(JTable tenBang,ArrayList<Phong> dsPhong){
        Vector tieuDe = new Vector();
        tieuDe.add("TÊN PHÒNG");
        tieuDe.add("LOẠI PHÒNG");
        tieuDe.add("TÌNH TRẠNG");
        tieuDe.add("GHI CHÚ");
        
        Vector data = new Vector();
        for(Phong p : dsPhong){
            Vector row = new Vector();
            row.add(p.getTenPhong());
            row.add(p.getTenLoaiP());
            row.add(p.getTinhTrang());
            row.add(p.getGhiChu());
            data.add(row);
        }
        
        //DefaultTableModel
        DefaultTableModel dtm = new DefaultTableModel(data,tieuDe){
            @Override
            public boolean isCellEditable(int row, int column){
                return false;
            }
        };
        tenBang.setModel(dtm);
    }
    
    
    public void bindingPhongTheoTang(JTable t, ArrayList<Phong> ds){
        //tiêu đề cột
        Vector clums = new Vector();
        clums.add("TÊN PHÒNG");
        clums.add("LOẠI PHÒNG");
        clums.add("TÌNH TRẠNG");
        
        //dữ liệu
        Vector data = new Vector();
        for(Phong p : ds){
            Vector temp = new Vector();
            temp.add(p.getTenPhong());
            temp.add(p.getTenLoaiP());
            temp.add(p.getTinhTrang());
            data.add(temp);
        }
        
        DefaultTableModel dtm = new DefaultTableModel(data,clums){
            @Override
            public boolean  isCellEditable(int row, int column){
                return false;
            }
        };
        t.setModel(dtm);
    }
    
    
    //đổ dữ liệu vào bảng dịch vụ
    public void bindingDichVu(JTable t, ArrayList<DichVu> danhsach){
        //tiêu đề bảng
        Vector clums = new Vector();
        clums.add("MÃ DỊCH VỤ");
        clums.add("TÊN DỊCH VỤ");
        clums.add("GIÁ DỊCH VỤ");
        clums.add("GHI CHÚ");
        
        //dữ liệu
        Vector data = new Vector();
        for(DichVu dv : danhsach){
            Vector row = new Vector();
            row.add(dv.getMaDV());
            row.add(dv.getTenDV());
            row.add(dv.getGiaDV());
            row.add(dv.getTinhTrang());
            data.add(row);
        }
        
        DefaultTableModel dtm = new DefaultTableModel(data,clums){
            @Override
            public boolean isCellEditable(int row, int column){
                return false;
            }
        };
        t.setModel(dtm);
    }
    
    
    //Lấy ngày giờ hệ thống và đặt theo định dạng
    public String getToDay(){
        Date today = new Date(System.currentTimeMillis());
        SimpleDateFormat  sdf = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
        String ngay = sdf.format(today);
        return ngay;
    }
    public String getDayNext(long day){
        Date today = new Date(System.currentTimeMillis() + day*86400000);
        SimpleDateFormat  sdf = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
        String ngay = sdf.format(today);
        return ngay;
    }
    
    
    //đỗ dữ liệu vào MENU
    public void bindingMenu(JTable t, ArrayList<DichVu> menu){
        Vector tieude = new Vector();
        tieude.add("Tên dịch vụ");
        tieude.add("Đơn giá");
        
        Vector data = new Vector();
        for(DichVu dv : menu){
            Vector row = new Vector();
            row.add(dv.getTenDV());
            row.add(dv.getGiaDV());
            data.add(row);
        }
        
        DefaultTableModel dtm = new DefaultTableModel(data,tieude){
            @Override
            public boolean isCellEditable(int row, int column){
                return false;
            }
        };
        t.setModel(dtm);
    }
    
    //đổ dữ liệu vào bảng order theo hóa đơn
    public void bindingOrder(JTable t, ArrayList<CT_PhieuDichVu> order){
        Vector tieude = new Vector();
        tieude.add("Tên dịch vụ");
        tieude.add("Đơn giá");
        tieude.add("Số lượng");
        tieude.add("Thành tiền");
        
        Vector data = new Vector();
        for(CT_PhieuDichVu ctdv : order){
            Vector row = new Vector();
            row.add(ctdv.getTenDV());
            row.add(ctdv.getDonGia());
            row.add(ctdv.getSoLuong());
            row.add(ctdv.getThanhTien());
            data.add(row);
        }
        
        DefaultTableModel dtm = new DefaultTableModel(data, tieude){
            @Override
            public boolean isCellEditable(int row, int column){
                //all cell false
                return false;
            }
        };
        t.setModel(dtm);
    }
    
    
    //Tính tiền thuê phòng 
    public String tienthue (String NgayBD, String NgayKT, double tiengiodau,double tienquadem) throws ParseException{
        SimpleDateFormat  sdf = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
        Date ngayBD = sdf.parse(NgayBD);
        Date ngayKT = sdf.parse(NgayKT);
        SimpleDateFormat layngay = new SimpleDateFormat("dd");
        int ngaybatdau = Integer.parseInt(layngay.format(ngayBD));
        int ngayketthuc = Integer.parseInt(layngay.format(ngayKT));
        if(ngaybatdau==ngayketthuc){
            //tính theo giá giờ
            long tong = (ngayKT.getTime() - ngayBD.getTime())/1000;//tính ra giây
            //nếu > 45phút(2700 giây) thì tính 1 giờ.
            long tonggio = tong/2700;
            double tienphaithu = 0;
            if(tonggio==0){
                tienphaithu = tiengiodau;
            }else{
                tienphaithu = tiengiodau +  (tonggio-1)*20;
            }
            return "" + tienphaithu;
        }else{
            //tính theo giá qua đêm
            int  songay = ngayketthuc - ngaybatdau;
            double tienphaithu = tienquadem*songay;
            return "" + tienphaithu;
        }
        //return "0";
    }
    
    //Kiểm soát chứng minh nhân dân nhập vào. ĐỂ đảm bảo nó k có chữ số.
    public boolean kiemtraCMND(String cmnd){
        boolean kiemtra = true;
        if(cmnd.length()>12)
            kiemtra =false;
        long socm = 0;
        //Nếu không chuyển từ String sang long đc thì báo lỗi
        try{
            socm = Long.parseLong(cmnd);
        }catch(Exception e){
            kiemtra = false;
        }
        
        
        return kiemtra;
    }
    
    //Load danh sách hóa đơn lên bảng
    public void bindingHoaDon(JTable t, ArrayList<HoaDon> hoadon){
        Vector tieude = new Vector();
        tieude.add("Mã hóa đơn");
        tieude.add("Mã phiếu thuê");
        tieude.add("Tiền dịch vụ");
        tieude.add("Tiền thuê phòng");
        tieude.add("Trị giá");
        tieude.add("Ngày hóa đơn");
        
        Vector data = new Vector();
        for(HoaDon hd : hoadon){
            Vector row = new Vector();
            row.add(hd.getMaHD());
            row.add(hd.getMaPhieuThue());
            row.add(hd.getTienDichVu());
            row.add(hd.getTienThuePhong());
            row.add(hd.getTriGiaHD());
            row.add(hd.getNgayHD());
            data.add(row);
        }
        
        DefaultTableModel dtm = new DefaultTableModel(data, tieude){
            @Override
            public boolean isCellEditable(int row, int column){
                //all cell false
                return false;
            }
        };
        t.setModel(dtm);
    }
}
