#pragma once

#include "Stdafx.h"
#include "Resource.h"
//#include "Control\\MacButtons.h"

//游戏设置对话框类 
class CGameSet : public CCoolView//CGameFaceGo
{

	//变量定义
public:
	bool								m_bSound;						//声音效果
	bool								m_bShowUser;					//是否显示用户 
	bool								m_bEnableWatch;					//是否允许旁观
	bool								m_bRightPower;
	CNormalBitmapButtonEx				m_Cancel;
	CNormalBitmapButtonEx				m_Ok;
	enum								{ IDD = IDD_GAME_SET };

	CButton								m_check_1;
	CButton								m_check_2;
	CButton								m_check_3;
	CButton								m_check_4;
		
	CWnd								*m_pParent;

	//函数定义 
public:
	//构造函数
	CGameSet(CWnd * pParent=NULL);
	//析构函数
	virtual ~CGameSet();
	//初始化对话框
	virtual BOOL OnInitDialog();

protected:
	//DDX/DDV 支持
	virtual void DoDataExchange(CDataExchange* pDX);    
	//确定按钮
	virtual void OnOK();

	DECLARE_MESSAGE_MAP()

	virtual LRESULT WindowProc(UINT message, WPARAM wParam, LPARAM lParam);
};
