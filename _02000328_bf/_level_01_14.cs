using System;

namespace Maple2.Trigger._02000328_bf {
    public static class _level_01_14 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(IDs: new int[] {5114}, isVisible: "false");
                context.SetMesh(
                    arg1: new int[] {
                        32401, 32402, 32403, 32404, 32405, 32406, 32407, 32408, 32409, 32410, 32411, 32412, 32413,
                        32414, 32415, 32416, 32417, 32418, 32419, 32420, 32421, 32422, 32423, 32424, 32425, 32426,
                        32427, 32428, 32429, 32430, 32431, 32432, 32433, 32434, 32435, 32436, 32437, 32438, 32439,
                        32440, 32441, 32442, 32443, 32444, 32445, 32446, 32447, 32448
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] { }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {10015})) {
                    context.SetMesh(
                        arg1: new int[] {
                            32401, 32402, 32403, 32404, 32405, 32406, 32407, 32408, 32409, 32410, 32411, 32412, 32413,
                            32414, 32415, 32416, 32417, 32418, 32419, 32420, 32421, 32422, 32423, 32424, 32425, 32426,
                            32427, 32428, 32429, 32430, 32431, 32432, 32433, 32434, 32435, 32436, 32437, 32438, 32439,
                            32440, 32441, 32442, 32443, 32444, 32445, 32446, 32447, 32448
                        }, arg2: true, arg3: 0, arg4: 100, arg5: 1f);
                    context.SetMesh(
                        arg1: new int[] {
                            42101, 42102, 42103, 42104, 42105, 42106, 42107, 42108, 42109, 42110, 42111, 42112, 42113,
                            42114, 42115, 42116, 42117, 42118, 42119, 42120, 42121, 42122, 42123, 42124, 42125, 42126,
                            42127, 42128, 42129, 42130, 42131, 42132, 42133, 42134, 42135, 42136, 42137, 42138, 42139,
                            42140, 42141, 42142, 42143, 42144, 42145, 42146, 42147, 42148, 42149, 42150, 42151, 42152,
                            42153, 42154, 42155, 42156, 42157, 42158, 42159, 42160, 42161, 42162, 42163, 42164, 42165,
                            42166, 42167, 42168, 42169, 42170, 42171, 42172, 42173, 42174, 42175, 42176, 42177, 42178,
                            42179, 42180, 42181, 42182, 42183, 42184, 42185, 42186, 42187, 42188, 42189, 42190, 42191,
                            42192, 42193, 42194, 42195, 42196, 42197, 42198, 42199, 42200, 42201, 42202, 42203, 42204,
                            42205, 42206, 42207, 42208, 42209, 42210, 42211, 42212, 42213, 42214, 42215, 42216, 42217,
                            42218, 42219, 42220, 42221, 42222, 42223, 42224, 42225, 42226, 42227, 42228, 42229, 42230,
                            42231, 42232, 42233, 42234, 42235, 42236, 42237, 42238, 42239, 42240, 42241, 42242, 42243,
                            42244, 42245, 42246, 42247, 42248, 42249, 42250, 42251, 42252, 42253, 42254, 42255, 42256,
                            42257, 42258, 42259, 42260, 42261, 42262, 42263, 42264, 42265, 42266, 42267, 42268, 42269,
                            42270, 42271, 42272, 42273, 42274, 42275, 42276, 42277, 42278, 42279, 42280, 42281, 42282,
                            42283, 42284, 42285, 42286, 42287, 42288, 42289, 42290, 42291, 42292, 42293, 42294, 42295,
                            42296, 42297, 42298, 42299, 42300, 42301, 42302
                        }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}