namespace Content.Client._FunkyStation.EdgeTrim;

    // The underlying logic for the EdgeTrim Component
    // Needs to do several things:
    //      Query for surrounding entities on the same grid with the EdgeTrim component, cataloguing what keys they use
    //      Build Cardinal Edges as 1x3 matrix [ 2, 0, 1 ] where 0 has nothing, 1 has a connection, 2 has an edge starting from the south edge and working ccw
    //      Assign pieces of the sprite depending on the matrix and supplementary direction flag
    //      Build the sprite using the pieces from the above method
    //      Update neighbors accordingly, don't update if all edges remain the same
    //
    // Considerations
    //      This is effectively me rebuilding IconSmoothing, and as such needs to handle if edge is undefined
    //      Needs to handle instances where there is no smoothed sprite and instead where it's just the key to add
    //      17 Sprites total to use with edge enabled, 8 if not
    //      Use the component to simplify logic (don't iterate through edge options if none exist)
    //      Integrate sprite variations, requires content.shared and content.server stuff to make sure the variations don't change randomly
    //      Diagonals?
    //      Lookup table?
