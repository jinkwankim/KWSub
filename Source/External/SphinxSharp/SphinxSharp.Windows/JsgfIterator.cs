//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Pocketsphinx {

public class JsgfIterator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JsgfIterator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JsgfIterator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JsgfIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          sphinxbasePINVOKE.delete_JsgfIterator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_jsgf_rule_iter_t ptr {
    set {
      sphinxbasePINVOKE.JsgfIterator_ptr_set(swigCPtr, SWIGTYPE_p_jsgf_rule_iter_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = sphinxbasePINVOKE.JsgfIterator_ptr_get(swigCPtr);
      SWIGTYPE_p_jsgf_rule_iter_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_jsgf_rule_iter_t(cPtr, false);
      return ret;
    } 
  }

  public JsgfIterator(SWIGTYPE_p_jsgf_rule_iter_t ptr) : this(sphinxbasePINVOKE.new_JsgfIterator(SWIGTYPE_p_jsgf_rule_iter_t.getCPtr(ptr)), true) {
  }

}

}
