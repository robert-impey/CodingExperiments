#include <stdio.h>
#include <stdlib.h>

struct point {
    float x;
    float y;
};
struct rectangle {
    struct point pt1;
    struct point pt2;
};

struct point make_point(float, float);

struct rectangle make_rectangle_from_floats(float, float, float, float);
struct rectangle make_rectangle_from_points(struct point, struct point);

float find_width_of_rectangle(struct rectangle);
float find_height_of_rectangle(struct rectangle);
float find_area_of_rectangle(struct rectangle);

float abs_float(float);

int main(int argc, char *argv[])
{
    if (argc > 1) {
        float area;
        struct rectangle my_rectangle;

        my_rectangle = make_rectangle_from_floats(atof(argv[1]), atof(argv[2]), atof(argv[3]), atof(argv[4]));

        area = find_area_of_rectangle(my_rectangle);

        printf("%.1f\n", area);
    }

    return 0;
}

struct point make_point(float x, float y)
{
    struct point tmp_pt;

    tmp_pt.x = x;
    tmp_pt.y = y;

    return tmp_pt;
}

struct rectangle make_rectangle_from_floats(float x1, float y1, float x2, float y2)
{
    struct rectangle tmp_rct;

    tmp_rct = make_rectangle_from_points(make_point(x1, y1), make_point(x2, y2));

    return tmp_rct;
}

struct rectangle make_rectangle_from_points(struct point pt1, struct point pt2)
{
    struct rectangle tmp_rct;

    tmp_rct.pt1 = pt1;
    tmp_rct.pt2 = pt2;

    return tmp_rct;
}

float find_width_of_rectangle(struct rectangle rct)
{
    float tmp_wth;

    tmp_wth = rct.pt1.x - rct.pt2.x;
    tmp_wth = abs_float(tmp_wth);

    return tmp_wth;
}

float find_height_of_rectangle(struct rectangle rct)
{
    float tmp_ht;

    tmp_ht = rct.pt1.y - rct.pt2.y;
    tmp_ht = abs_float(tmp_ht);

    return tmp_ht;
}

float find_area_of_rectangle(struct rectangle rct)
{
    float tmp_ar;

    tmp_ar = find_width_of_rectangle(rct) * find_height_of_rectangle(rct);

    return tmp_ar;
}

float abs_float(float f)
{
    if (f < 0.0) {
        f *= -1.0;
    }
    return f;
}
