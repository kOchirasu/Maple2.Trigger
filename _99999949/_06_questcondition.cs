using System;

namespace Maple2.Trigger._99999949 {
    public static class _06_questcondition {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {11000064}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9051})) {
                    context.AddEffectNif(spawnPointID: 11000064,
                        nifPath: @"Map\Royalcity\Indoor\ry_in_cubric_mat_A01.nif", isOutline: true, scale: 0.5f,
                        rotateZ: 45);
                    context.FaceEmotion(emotionName: "Ride_Idle_000");
                    context.State = new StateWait2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait2 : TriggerState {
            internal StateWait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "AddEffectNif 테스트");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateGuide(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveEffectNif(spawnPointID: 11000064);
                context.FaceEmotion();
            }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "40002673퀘스트 완료가능 or 완료 상태를 만들고 6번 영역안에 들어가보세요.");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9050},
                    arg2: new int[] {40002673, 40002674, 40002675, 40002676, 40002677, 40002678, 40002679},
                    arg3: new byte[] {1})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {11000064});
                context.CreateMonster(arg1: new int[] {11000044}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {11000044});
                context.DebugString(@string: "5초 후에 트리거가 리셋됩니다. 6번 영역 밖으로 나가세요.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}