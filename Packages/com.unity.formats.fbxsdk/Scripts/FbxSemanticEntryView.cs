//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Unity.FbxSdk {

public class FbxSemanticEntryView : FbxEntryView {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSemanticEntryView(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GlobalsPINVOKE.FbxSemanticEntryView_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSemanticEntryView obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxSemanticEntryView() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GlobalsPINVOKE.delete_FbxSemanticEntryView(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxSemanticEntryView(FbxBindingTableEntry pEntry, bool pAsSource, bool pCreate) : this(GlobalsPINVOKE.new_FbxSemanticEntryView__SWIG_0(FbxBindingTableEntry.getCPtr(pEntry), pAsSource, pCreate), true) {
  }

  public FbxSemanticEntryView(FbxBindingTableEntry pEntry, bool pAsSource) : this(GlobalsPINVOKE.new_FbxSemanticEntryView__SWIG_1(FbxBindingTableEntry.getCPtr(pEntry), pAsSource), true) {
  }

  public void SetSemantic(string pSemantic) {
    GlobalsPINVOKE.FbxSemanticEntryView_SetSemantic(swigCPtr, pSemantic);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetSemantic(bool pAppendIndex) {
    string ret = GlobalsPINVOKE.FbxSemanticEntryView_GetSemantic__SWIG_0(swigCPtr, pAppendIndex);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetSemantic() {
    string ret = GlobalsPINVOKE.FbxSemanticEntryView_GetSemantic__SWIG_1(swigCPtr);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetIndex() {
    int ret = GlobalsPINVOKE.FbxSemanticEntryView_GetIndex(swigCPtr);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}