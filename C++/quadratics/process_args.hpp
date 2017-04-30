struct Args {
    float a;
    float b;
    float c;
    bool d;
};

void init_args(Args *args);
bool process_args(int argc, char** argv, Args* args);

