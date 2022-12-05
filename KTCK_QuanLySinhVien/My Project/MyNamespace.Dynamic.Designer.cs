using System;
using System.ComponentModel;
using System.Diagnostics;

namespace KTCK_QuanLySinhVien.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public LopHocPhan m_LopHocPhan;

            public LopHocPhan LopHocPhan
            {
                [DebuggerHidden]
                get
                {
                    m_LopHocPhan = Create__Instance__(m_LopHocPhan);
                    return m_LopHocPhan;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_LopHocPhan))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_LopHocPhan);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Sua m_Sua;

            public Sua Sua
            {
                [DebuggerHidden]
                get
                {
                    m_Sua = Create__Instance__(m_Sua);
                    return m_Sua;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Sua))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Sua);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Them m_Them;

            public Them Them
            {
                [DebuggerHidden]
                get
                {
                    m_Them = Create__Instance__(m_Them);
                    return m_Them;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Them))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Them);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public ThoiKhoaBieu m_ThoiKhoaBieu;

            public ThoiKhoaBieu ThoiKhoaBieu
            {
                [DebuggerHidden]
                get
                {
                    m_ThoiKhoaBieu = Create__Instance__(m_ThoiKhoaBieu);
                    return m_ThoiKhoaBieu;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ThoiKhoaBieu))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ThoiKhoaBieu);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public TrangChu m_TrangChu;

            public TrangChu TrangChu
            {
                [DebuggerHidden]
                get
                {
                    m_TrangChu = Create__Instance__(m_TrangChu);
                    return m_TrangChu;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TrangChu))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TrangChu);
                }
            }

        }


    }
}