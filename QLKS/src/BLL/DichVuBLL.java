/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BLL;

import DAL.DichVuDAL;
import DTO.DichVu;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class DichVuBLL {
    DichVuDAL DAL = new DichVuDAL();
    //lấy tất cả dịch vụ
    public ArrayList<DichVu> getAll(){
        return DAL.getAll();
    }
    

    //lấy dịch vụ trong trạng thái sẵn sàng
    public ArrayList<DichVu> layDichVuSanSang(){
        return DAL.layDichVuSanSang();
    }
    
    
    
    //Lấy mã dịch vụ bằng tên dịch vụ
    public String layMaDV(String tenDV){
        return DAL.layMaDV(tenDV);
    }
    
    
}
