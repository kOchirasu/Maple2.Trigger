namespace Maple2.Trigger._02000253_bf {
    public static class _move {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2901, 2902, 2903, 2904, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3901, 3902, 3903, 3904, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, arg2: false);
                context.SetEffect(arg1: new[] {8041, 8042, 8043, 8044}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 906) == 1) {
                    context.State = new State벨라소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라소환 : TriggerState {
            internal State벨라소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라이동 : TriggerState {
            internal State벨라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State랜덤선택1 : TriggerState {
            internal State랜덤선택1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State1번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State2번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State3번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State4번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤선택11 : TriggerState {
            internal State랜덤선택11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State2번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State3번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State4번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤선택12 : TriggerState {
            internal State랜덤선택12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State1번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State3번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State4번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤선택13 : TriggerState {
            internal State랜덤선택13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State1번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State2번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State4번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤선택14 : TriggerState {
            internal State랜덤선택14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State1번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State2번(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State3번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번 : TriggerState {
            internal State1번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002523, textId: 20002523);
                context.SetEffect(arg1: new[] {8041}, arg2: true);
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904}, arg2: true);
                context.SetBreakable(arg1: new[] {905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.HideGuideSummary(entityId: 20002523);
                    context.State = new State11번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State11번 : TriggerState {
            internal State11번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8041}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.CreateMonster(arg1: new[] {3001});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {3001});
                    context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                    context.State = new State랜덤선택11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {3001})) {
                    context.State = new State12번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12번 : TriggerState {
            internal State12번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10001052}, arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {3001});
                    context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                    context.State = new State랜덤선택11(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001052}, arg2: 0)) {
                    context.State = new State끝1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번 : TriggerState {
            internal State2번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8042}, arg2: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002523, textId: 20002523);
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetBreakable(arg1: new[] {905, 906, 907, 908, 1905, 1906, 1907, 1908, 2905, 2906, 2907, 2908, 3905, 3906, 3907, 3908}, arg2: true);
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 909, 910, 911, 912, 913, 914, 915, 916, 1901, 1902, 1903, 1904, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2901, 2902, 2903, 2904, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3901, 3902, 3903, 3904, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.HideGuideSummary(entityId: 20002523);
                    context.State = new State21번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State21번 : TriggerState {
            internal State21번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8042}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.CreateMonster(arg1: new[] {3002});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {3002});
                    context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                    context.State = new State랜덤선택12(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {3002})) {
                    context.State = new State22번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State22번 : TriggerState {
            internal State22번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10001051}, arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {3004});
                    context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                    context.State = new State랜덤선택12(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001051}, arg2: 0)) {
                    context.State = new State끝2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번 : TriggerState {
            internal State3번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8044}, arg2: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002523, textId: 20002523);
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetBreakable(arg1: new[] {909, 910, 911, 912, 1909, 1910, 1911, 1912, 2909, 2910, 2911, 2912, 3909, 3910, 3911, 3912}, arg2: true);
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 913, 914, 915, 916, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1913, 1914, 1915, 1916, 2901, 2902, 2903, 2904, 2905, 2906, 2907, 2908, 2913, 2914, 2915, 2916, 3901, 3902, 3903, 3904, 3905, 3906, 3907, 3908, 3913, 3914, 3915, 3916}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.HideGuideSummary(entityId: 20002523);
                    context.State = new State31번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State31번 : TriggerState {
            internal State31번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8044}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.CreateMonster(arg1: new[] {3003});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {3003});
                    context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                    context.State = new State랜덤선택13(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {3003})) {
                    context.State = new State32번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State32번 : TriggerState {
            internal State32번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10001050}, arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {3004});
                    context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                    context.State = new State랜덤선택13(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001050}, arg2: 0)) {
                    context.State = new State끝3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번 : TriggerState {
            internal State4번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8043}, arg2: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002523, textId: 20002523);
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetBreakable(arg1: new[] {913, 914, 915, 916, 1913, 1914, 1915, 1916, 2913, 2914, 2915, 2916, 3913, 3914, 3915, 3916}, arg2: true);
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 2901, 2902, 2903, 2904, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 3901, 3902, 3903, 3904, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.HideGuideSummary(entityId: 20002523);
                    context.State = new State41번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State41번 : TriggerState {
            internal State41번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8043}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.CreateMonster(arg1: new[] {3004});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {3004});
                    context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                    context.State = new State랜덤선택14(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {3004})) {
                    context.State = new State42번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State42번 : TriggerState {
            internal State42번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10001053}, arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.DestroyMonster(arg1: new[] {3004});
                    context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                    context.State = new State랜덤선택14(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001053}, arg2: 0)) {
                    context.State = new State끝4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝1 : TriggerState {
            internal State끝1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State랜덤선택11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝2 : TriggerState {
            internal State끝2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State랜덤선택12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝3 : TriggerState {
            internal State끝3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State랜덤선택13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝4 : TriggerState {
            internal State끝4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new[] {10001050, 10001051, 10001052, 10001053}, arg2: 2);
                context.SetBreakable(arg1: new[] {901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State랜덤선택14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}