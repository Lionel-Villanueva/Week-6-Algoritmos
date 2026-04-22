using UnityEngine;
using Sirenix.OdinInspector;

public class StackNode<T>
{
    #region privates
    private T value;
    private StackNode<T> next;
    #endregion

    #region constrauctor
    public StackNode(T value)
    {
        this.value = value;
        next = null;
    }
    #endregion

    #region public methods
    public void SetNext(StackNode<T> nextNode)
    {
        next = nextNode;
    }

    public T Value => value;
    public StackNode<T> Next => next;
    #endregion

}
