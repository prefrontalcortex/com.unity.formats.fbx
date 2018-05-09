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

public class FbxCamera : FbxNodeAttribute {
  internal FbxCamera(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxCamera Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = GlobalsPINVOKE.FbxCamera_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxCamera ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCamera(cPtr, false);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxCamera Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = GlobalsPINVOKE.FbxCamera_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxCamera ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCamera(cPtr, false);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAspect(FbxCamera.EAspectRatioMode pRatioMode, double pWidth, double pHeight) {
    GlobalsPINVOKE.FbxCamera_SetAspect(swigCPtr, (int)pRatioMode, pWidth, pHeight);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxCamera.EAspectRatioMode GetAspectRatioMode() {
    FbxCamera.EAspectRatioMode ret = (FbxCamera.EAspectRatioMode)GlobalsPINVOKE.FbxCamera_GetAspectRatioMode(swigCPtr);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetNearPlane(double pDistance) {
    GlobalsPINVOKE.FbxCamera_SetNearPlane(swigCPtr, pDistance);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetNearPlane() {
    double ret = GlobalsPINVOKE.FbxCamera_GetNearPlane(swigCPtr);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFarPlane(double pDistance) {
    GlobalsPINVOKE.FbxCamera_SetFarPlane(swigCPtr, pDistance);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetFarPlane() {
    double ret = GlobalsPINVOKE.FbxCamera_GetFarPlane(swigCPtr);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetApertureMode(FbxCamera.EApertureMode pMode) {
    GlobalsPINVOKE.FbxCamera_SetApertureMode(swigCPtr, (int)pMode);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxCamera.EApertureMode GetApertureMode() {
    FbxCamera.EApertureMode ret = (FbxCamera.EApertureMode)GlobalsPINVOKE.FbxCamera_GetApertureMode(swigCPtr);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetApertureWidth(double pWidth) {
    GlobalsPINVOKE.FbxCamera_SetApertureWidth(swigCPtr, pWidth);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetApertureWidth() {
    double ret = GlobalsPINVOKE.FbxCamera_GetApertureWidth(swigCPtr);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetApertureHeight(double pHeight) {
    GlobalsPINVOKE.FbxCamera_SetApertureHeight(swigCPtr, pHeight);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetApertureHeight() {
    double ret = GlobalsPINVOKE.FbxCamera_GetApertureHeight(swigCPtr);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ComputeFocalLength(double pAngleOfView) {
    double ret = GlobalsPINVOKE.FbxCamera_ComputeFocalLength(swigCPtr, pAngleOfView);
    if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyDouble AspectWidth {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(GlobalsPINVOKE.FbxCamera_AspectWidth_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble AspectHeight {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(GlobalsPINVOKE.FbxCamera_AspectHeight_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble FieldOfView {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(GlobalsPINVOKE.FbxCamera_FieldOfView_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble FocalLength {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(GlobalsPINVOKE.FbxCamera_FocalLength_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble NearPlane {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(GlobalsPINVOKE.FbxCamera_NearPlane_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble FilmAspectRatio {
    get {
      FbxPropertyDouble ret = new FbxPropertyDouble(GlobalsPINVOKE.FbxCamera_FilmAspectRatio_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyEProjectionType ProjectionType {
    get {
      FbxPropertyEProjectionType ret = new FbxPropertyEProjectionType(GlobalsPINVOKE.FbxCamera_ProjectionType_get(swigCPtr), false);
      if (GlobalsPINVOKE.SWIGPendingException.Pending) throw GlobalsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxCamera other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxCamera;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxCamera).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxCamera a, FbxCamera b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxCamera a, FbxCamera b) {
    return !(a == b);
  }

  public enum EProjectionType {
    ePerspective,
    eOrthogonal
  }

  public enum EAspectRatioMode {
    eWindowSize,
    eFixedRatio,
    eFixedResolution,
    eFixedWidth,
    eFixedHeight
  }

  public enum EApertureMode {
    eHorizAndVert,
    eHorizontal,
    eVertical,
    eFocalLength
  }

}

}